using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using SGComserv.AbstractClass;
using SGComserv.Attributes;
using SGComserv.Entitys;
using SGComserv.Models;

namespace SGComserv.Extensions;

public static class ModelExtensions
{
    /// <summary>
    /// Obter o nome da tabela usando o tipo da classe
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="type"></param>
    /// <returns></returns>
    /// <example>typeof(Classe).GetTableName()</example>
    public static string GetTableName(this Type type)
    {
        TableAttribute? tableAttribute = type.GetCustomAttributes(typeof(TableAttribute), true).FirstOrDefault() as TableAttribute;
        return tableAttribute != null ? tableAttribute.Name : type.Name;
    }

    public static string GetPrincipalTableName(this Type type)
    {
        MainTableAttribute? tableAttribute = type.GetCustomAttributes(typeof(MainTableAttribute), true).FirstOrDefault() as MainTableAttribute;
        return tableAttribute != null ? tableAttribute.MainTable : type.Name;
    }

    /// <summary>
    /// Obter uma lista de nomes de propriedades usando a instância da classe
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="instance"></param>
    /// <returns></returns>
    /// <example>registro.GetPropertyNames()</example>
    public static List<ViewModel> GetPropertyNames<T>(this T instance) where T : BaseEntity<T>
    {
        return typeof(T).GetProperties()
                        .Select(prop =>
                        {
                            DisplayAttribute? displayAttribute = prop.GetCustomAttribute<DisplayAttribute>();
                            string nome = prop.Name;
                            string description = displayAttribute?.Name ?? string.Empty;
                            return new ViewModel
                            {
                                valueMember = description,
                                displayValue = nome,
                            };
                        })
                        .ToList();
    }

    /// <summary>
    /// Obter detalhes de uma propriedade específica
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="instance"></param>
    /// <param name="propertyName"></param>
    /// <returns></returns>
    /// <example>registro.GetPropertyDetails("DataCriacao")</example>
    public static PropertyInfo? GetPropertyDetails<T>(this T instance, string propertyName) where T : BaseEntity<T>
    {
        return typeof(T).GetProperty(propertyName);
    }

    /// <summary>
    /// Obter propriedades com um determinado atributo
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TAttribute"></typeparam>
    /// <param name="instance"></param>
    /// <returns></returns>
    /// <example>registro.GetPropertiesWithAttribute<Classe, KeyAttribute>()</example>
    public static List<PropertyInfo> GetPropertiesWithAttribute<T, TAttribute>(this T instance) where T : BaseEntity<T> where TAttribute : Attribute
    {
        return typeof(T).GetProperties()
            .Where(p => p.GetCustomAttributes(typeof(TAttribute), true).Any())
            .ToList();
    }

    /// <summary>
    /// Verificar se uma propriedade existe
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="instance"></param>
    /// <param name="propertyName"></param>
    /// <returns></returns>
    /// <example>registro.PropertyExists("DataCriacao")</example>
    public static bool PropertyExists<T>(this T instance, string propertyName) where T : BaseEntity<T>
    {
        return typeof(T).GetProperty(propertyName) != null;
    }

    /// <summary>
    /// Método para copiar propriedades
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="source"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public static T Copy<T>(this T source) 
    {
        T target = (T)Activator.CreateInstance(typeof(T));

        if (source == null)
            throw new ArgumentNullException("Source or target is null");

        PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach (PropertyInfo property in properties)
        {
            if (property.CanWrite)
            {
                object value = property.GetValue(source);
                property.SetValue(target, value);
            }
        }

        return target;
    }

    /// <summary>
    /// Copia os valores das propriedades de um objeto de origem para outro de destino,
    /// preenchendo apenas as propriedades correspondentes.
    /// </summary>
    /// <typeparam name="TSource">Tipo do objeto de origem.</typeparam>
    /// <typeparam name="TDestination">Tipo do objeto de destino.</typeparam>
    /// <param name="source">Objeto de origem.</param>
    /// <param name="destination">Objeto de destino.</param>
    public static void CopyTo<TSource, TDestination>(this TSource source, TDestination destination)
    {
        if (source == null) throw new ArgumentNullException(nameof(source));
        if (destination == null) throw new ArgumentNullException(nameof(destination));

        var sourceProperties = typeof(TSource).GetProperties()
            .Where(p => p.CanRead);
        var destinationProperties = typeof(TDestination).GetProperties()
            .Where(p => p.CanWrite);

        foreach (var sourceProp in sourceProperties)
        {
            var destinationProp = destinationProperties
                .FirstOrDefault(p => p.Name == sourceProp.Name && p.PropertyType.IsAssignableFrom(sourceProp.PropertyType));

            if (destinationProp != null)
            {
                var value = sourceProp.GetValue(source);
                destinationProp.SetValue(destination, value);
            }
        }
    }

    /// <summary>
    /// Método para comparar se todas as propriedades são iguais
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="obj1"></param>
    /// <param name="obj2"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static bool IsEquals<T>(this T obj1, T obj2) where T : BaseEntity<T>
    {
        if (obj1 == null || obj2 == null)
            throw new ArgumentNullException("Um ou ambos os objetos são nulos");

        PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach (PropertyInfo property in properties)
        {
            object? value1 = property?.GetValue(obj1) ?? null;
            object? value2 = property?.GetValue(obj2) ?? null;

            if (value1 == null && value2 == null)
                continue;

            if (value1 == null || value2 == null || !value1.Equals(value2))
                return false;
        }

        return true;
    }

    /// <summary>
    /// Recebe dois objetos e compara os valores para validar se houve alteração e em qual campo foi feita a alteração
    /// </summary>
    /// <param name="initialState">Estado inicial</param>
    /// <param name="currentState">Estado ao sofrer alteração</param>
    /// <returns>List de Model.Historico</returns>
    public static List<HistoricoEntity> CompareTo<T>(this T initialState, T currentState) where T : BaseEntity<T>
    {
        List<HistoricoEntity> listHistoric = new List<HistoricoEntity>();
        PropertyInfo[] properties = initialState.GetType().GetProperties();
        
        string idObjectT = string.Empty;

        string? tableName = typeof(T).GetCustomAttributes(typeof(TableAttribute), true)
                            .Cast<TableAttribute>()
                            .SingleOrDefault()?.Name ?? typeof(T).GetProperty("TableName")?.GetValue(null)?.ToString();

        for (int i = 0; i < properties.Length; i++)
        {
            PropertyInfo property = properties[i];

            if (Attribute.IsDefined(property, typeof(KeyAttribute)))
            {
                idObjectT = property.GetValue(currentState).ToString();
            }

            if (Attribute.IsDefined(property, typeof(IgnoreOnHistoricAttribute)))
            {
                continue;
            }

            object initialValue = property.GetValue(initialState);
            object currentValue = property.GetValue(currentState);

            bool isDifferent = false;

            if (initialValue is decimal || initialValue is double || initialValue is float)
            {
                decimal decimalInitialValue = Convert.ToDecimal(initialValue);
                decimal decimalCurrentValue = Convert.ToDecimal(currentValue);
                isDifferent = decimalInitialValue != decimalCurrentValue;
            }
            else if (initialValue is byte[] initialBytes && currentValue is byte[] currentBytes)
            {
                isDifferent = !initialBytes.SequenceEqual(currentBytes);
            }
            else if (initialValue is IComparable)
            {
                isDifferent = !initialValue.Equals(currentValue);
            }
            else
            {
                isDifferent = !object.Equals(initialValue, currentValue);
            }

            if (isDifferent)
            {
                HistoricoEntity history = new HistoricoEntity()
                {
                    tabela = tableName,
                    idObjeto = idObjectT,
                    nomeUsuarioAlteracao = string.Empty,
                    nomeCampo = property.Name,
                    valorAntigo = initialValue is byte[]? string.Empty : Convert.ToString(initialValue),
                    novoValor = currentValue is byte[]? string.Empty : Convert.ToString(currentValue),
                    descricaoCampo = property.GetCustomAttributes(typeof(DisplayAttribute))
                                          .Cast<DisplayAttribute>()
                                          .SingleOrDefault()?.Name,
                    dataAlteracao = DateTime.Now,
                };

                listHistoric.Add(history);
            }
        }

        return listHistoric;
    }

}