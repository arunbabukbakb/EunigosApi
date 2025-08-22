using EunigosApi.Common;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity;
using EunigosApi.Models.Entity.CustomerManagement;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq.Expressions;
using System.Runtime.Serialization;

namespace EunigosApi.FilteringPagination
{
    public static class QueryableExtensions
    {



        public static IQueryable<T> ApplyFilter<T>(IQueryable<T> query, Filter filter)
        {
          if (filter == null || string.IsNullOrWhiteSpace(filter.Field))
            {
                return query;
            }
         else
            {
                filter.Field = UtilityHelper.ToPascalCase(filter.Field);
            }
   
            switch (filter.Operator.ToLower())
            {
                case "eq":
                    // Specify the type T explicitly when calling BuildEqualsExpression
                    query = query.Where(BuildEqualsExpression<T>(filter));
                    break;

                case "ne":
                    query = query.Where(BuildNotEqualsExpression<T>(filter));
                    break;
                case "contains":
                    query = query.Where(BuildContainsExpression<T>(filter));
                    break;
                case "lt":
                    query = query.Where(BuildLessThanExpression<T>(filter));
                    break;
                case "gt":
                    query = query.Where(BuildGreaterThanExpression<T>(filter));
                    break;
                case "lte":
                    query = query.Where(BuildLessThanOrEqualExpression<T>(filter));
                    break;
                case "gte":
                    query = query.Where(BuildGreaterThanOrEqualExpression<T>(filter));
                    break;
                case "in":
                    query = query.Where(BuildInExpression<T>(filter));
                    break;
                case "nin":
                    query = query.Where(BuildNotInExpression<T>(filter));
                    break;
                case "startswith":
                    query = query.Where(BuildStartsWithExpression<T>(filter));
                    break;
                case "endswith":
                    query = query.Where(BuildEndsWithExpression<T>(filter));
                    break;
                case "null":
                    query = query.Where(BuildIsNullExpression<T>(filter));
                    break;
                case "nnull":
                    query = query.Where(BuildIsNotNullExpression<T>(filter));
                    break;
                case "between":
                    query = query.Where(BuildBetweenExpression<T>(filter));
                    break;
                // Add more cases as needed
                default:
                    throw new NotSupportedException($"Filter operator '{filter.Operator}' is not supported.");
            }

            return query;
        }

        private static string ToPascalCase(string field)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// eq: Equal to
        // Example: {"field": "status", "operator": "eq", "value": "active"}
        //Matches records where the status is exactly "active"
        /// </summary>
        public static Expression<Func<T, bool>> BuildEqualsExpression<T>(Filter filter)
            {
                // Create a parameter expression (e.g., 't' => t.Property)
                var parameter = Expression.Parameter(typeof(T), "t");

                // Get the property expression (t.PropertyName)
                var property = Expression.Property(parameter, filter.Field);

                // Check if the property type is Enum
                object value;
                if (property.Type.IsEnum)
                {
                    // Use a custom method to convert string to Enum based on EnumMember values
                    value = GetEnumValueFromEnumMember(property.Type, filter.Value.ToString());
                }
                else
                {
                    // For non-enum types, just use Convert.ChangeType
                    value = Convert.ChangeType(filter.Value, property.Type);
                }

                // Create the equality expression (t.PropertyName == filterValue)
                var valueExpression = Expression.Constant(value);
                var equal = Expression.Equal(property, valueExpression);

                // Build and return the lambda expression (t => t.PropertyName == filterValue)
                return Expression.Lambda<Func<T, bool>>(equal, parameter);
            }
       private static object GetEnumValueFromEnumMember(Type enumType, string enumMemberValue)
        {
            foreach (var field in enumType.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field, typeof(EnumMemberAttribute)) as EnumMemberAttribute;

                if (attribute?.Value == enumMemberValue)
                    return Enum.Parse(enumType, field.Name);
 
                if (field.Name.Equals(enumMemberValue, StringComparison.OrdinalIgnoreCase))
                    return Enum.Parse(enumType, field.Name);
            }

            throw new ArgumentException($"Invalid value '{enumMemberValue}' for enum type '{enumType.Name}'.");
        }
                

        /// <summary>
        /// ne: Not equal to
        // Example: {"field": "status", "operator": "ne", "value": "inactive"}
        //Matches records where the status is anything other than "inactive"
        /// </summary>
        public static Expression<Func<T, bool>> BuildNotEqualsExpression<T>(Filter filter)
        {
            // Create a parameter expression (e.g., 't' => t.Property)
            var parameter = Expression.Parameter(typeof(T), "t");

            // Get the property expression (t.PropertyName)
            var property = Expression.Property(parameter, filter.Field);

            object value;
            if (property.Type.IsEnum)
            {
                // Use a custom method to convert string to Enum based on EnumMember values
                value = GetEnumValueFromEnumMember(property.Type, filter.Value.ToString());
            }
            else
            {
                // For non-enum types, just use Convert.ChangeType
                value = Convert.ChangeType(filter.Value, property.Type);
            }
            var valueExpression = Expression.Constant(value);
            var equal = Expression.NotEqual(property, valueExpression);

            // Build and return the lambda expression (t => t.PropertyName == filterValue)
            return Expression.Lambda<Func<T, bool>>(equal, parameter);
        }
        /// <summary>
        /// lt: Less than
        /// Example: {"field": "age", "operator": "lt", "value": 30}
        //Matches records where the age is less than 30
        /// </summary

            public static Expression<Func<T, bool>> BuildLessThanExpression<T>(Filter filter)
        {
            // Create a parameter expression (e.g., 't' => t.Property)
            var parameter = Expression.Parameter(typeof(T), "t");

            // Get the property expression (t.PropertyName)
            var property = Expression.Property(parameter, filter.Field);

            object value;
            if (property.Type.IsEnum)
            {
                // Use the GetEnumValueFromEnumMember method to convert the string to Enum
                value = GetEnumValueFromEnumMember(property.Type, filter.Value.ToString());
            }
            else
            {
                // For non-enum types, just use Convert.ChangeType
                value = Convert.ChangeType(filter.Value, property.Type);
            }

            var valueExpression = Expression.Constant(value);

            // Ensure the property type is comparable (e.g., int, float, DateTime, etc.)
            if (!typeof(IComparable).IsAssignableFrom(property.Type))
            {
                throw new InvalidOperationException("LessThan can only be used with comparable types.");
            }

            var lessThanExpression = Expression.LessThan(property, valueExpression);

            // Build and return the lambda expression (t => t.PropertyName < filterValue)
            return Expression.Lambda<Func<T, bool>>(lessThanExpression, parameter);
        }



       public static Expression<Func<T, bool>> BuildGreaterThanExpression<T>(Filter filter)
        {
            // Create a parameter expression (e.g., 't' => t.Property)
            var parameter = Expression.Parameter(typeof(T), "t");

            // Get the property expression (t.PropertyName)
            var property = Expression.Property(parameter, filter.Field);

            object value;
            if (property.Type.IsEnum)
            {
                // Use the GetEnumValueFromEnumMember method to convert the string to Enum
                value = GetEnumValueFromEnumMember(property.Type, filter.Value.ToString());
            }
            else
            {
                // For non-enum types, just use Convert.ChangeType
                value = Convert.ChangeType(filter.Value, property.Type);
            }

            var valueExpression = Expression.Constant(value);

            // Ensure the property type is comparable (e.g., int, float, DateTime, etc.)
            if (!typeof(IComparable).IsAssignableFrom(property.Type))
            {
                throw new InvalidOperationException("GreaterThan can only be used with comparable types.");
            }

            var greaterThanExpression = Expression.GreaterThan(property, valueExpression);

            // Build and return the lambda expression (t => t.PropertyName > filterValue)
            return Expression.Lambda<Func<T, bool>>(greaterThanExpression, parameter);
        }



        public static Expression<Func<T, bool>> BuildLessThanOrEqualExpression<T>(Filter filter)
        {
            // Create a parameter expression (e.g., 't' => t.Property)
            var parameter = Expression.Parameter(typeof(T), "t");

            // Get the property expression (t.PropertyName)
            var property = Expression.Property(parameter, filter.Field);

            // Convert the filter value to the correct type of the property
            var filterValue = Expression.Constant(Convert.ChangeType(filter.Value, property.Type));

            // Ensure the property type is comparable (e.g., int, float, DateTime, etc.)
            if (!typeof(IComparable).IsAssignableFrom(property.Type))
            {
                throw new InvalidOperationException("LessThanOrEqual can only be used with comparable types.");
            }

            // Build the LessThanOrEqual expression (t.PropertyName <= filterValue)
            var lessThanOrEqualExpression = Expression.LessThanOrEqual(property, filterValue);

            // Build and return the lambda expression (t => t.PropertyName <= filterValue)
            return Expression.Lambda<Func<T, bool>>(lessThanOrEqualExpression, parameter);
        }

        public static Expression<Func<T, bool>> BuildGreaterThanOrEqualExpression<T>(Filter filter)
        {
            // Create a parameter expression (e.g., 't' => t.Property)
            var parameter = Expression.Parameter(typeof(T), "t");

            // Get the property expression (t.PropertyName)
            var property = Expression.Property(parameter, filter.Field);

            object value;
            if (property.Type.IsEnum)
            {
                // Use the GetEnumValueFromEnumMember method to convert the string to Enum
                value = GetEnumValueFromEnumMember(property.Type, filter.Value.ToString());
            }
            else
            {
                // For non-enum types, just use Convert.ChangeType
                value = Convert.ChangeType(filter.Value, property.Type);
            }

            var valueExpression = Expression.Constant(value);

            // Ensure the property type is comparable (e.g., int, float, DateTime, etc.)
            if (!typeof(IComparable).IsAssignableFrom(property.Type))
            {
                throw new InvalidOperationException("GreaterThanOrEqual can only be used with comparable types.");
            }

            var greaterThanOrEqualExpression = Expression.GreaterThanOrEqual(property, valueExpression);

            // Build and return the lambda expression (t => t.PropertyName >= filterValue)
            return Expression.Lambda<Func<T, bool>>(greaterThanOrEqualExpression, parameter);
        }

       public static Expression<Func<T, bool>> BuildContainsExpression<T>(Filter filter)
        {
            // Create a parameter expression (e.g., 't' => t.Property)
            var parameter = Expression.Parameter(typeof(T), "t");

            // Get the property expression (t.PropertyName)
            var property = Expression.Property(parameter, filter.Field);

            // Convert the filter value to the correct type of the property (this will work for strings and enums)
            object filterValue;

            // Handle enum values using EnumMemberAttribute if the property is an enum
            if (property.Type.IsEnum)
            {
                // Use GetEnumValueFromEnumMember to get the enum value from string representation
                filterValue = GetEnumValueFromEnumMember(property.Type, filter.Value.ToString());
            }
            else
            {
                // For non-enum types, use ChangeType to convert the filter value to the correct type
                filterValue = Convert.ChangeType(filter.Value, property.Type);
            }

            Expression containsExpression;

            // Check if the property is a string
            if (property.Type == typeof(string))
            {
                // Get the Contains method of the string type
                var containsMethod = typeof(string).GetMethod("Contains", new[] { typeof(string) });

                // Create the Contains expression (t.PropertyName.Contains(filterValue))
                containsExpression = Expression.Call(property, containsMethod, Expression.Constant(filterValue));
            }
            // If the property is a collection, we check if it contains the filter value
            else if (typeof(IEnumerable<>).MakeGenericType(property.Type).IsAssignableFrom(property.Type))
            {
                var containsMethod = typeof(Enumerable).GetMethods()
                    .First(m => m.Name == "Contains" && m.GetParameters().Length == 2)
                    .MakeGenericMethod(property.Type);

                containsExpression = Expression.Call(null, containsMethod, property, Expression.Constant(filterValue));
            }
            else if (property.Type.IsEnum) 
            {
                // For enum properties, use equality instead of contains
                containsExpression = Expression.Equal(property, Expression.Constant(filterValue, property.Type));
            }
            else
            {
                throw new InvalidOperationException("Contains can only be used with strings, collections, or enums.");
            }

            // Build and return the lambda expression (t => t.PropertyName.Contains(filterValue))
            return Expression.Lambda<Func<T, bool>>(containsExpression, parameter);
        }


        public static Expression<Func<T, bool>> BuildInExpression<T>(Filter filter)
        {
            // Create a parameter expression (e.g., 't' => t.Property)
            var parameter = Expression.Parameter(typeof(T), "t");

            // Get the property expression (t.PropertyName)
            var property = Expression.Property(parameter, filter.Field);

            // Get the type of the property
            var propertyType = property.Type;

            // Convert the filter value into a collection of the correct type (filter.Value should be an array or list)
            var filterValues = ((IEnumerable)filter.Value).Cast<object>()
                              .Select(value => Convert.ChangeType(value, propertyType))
                              .ToArray();

            // Create a constant expression for the collection
            var collection = Expression.Constant(filterValues);

            // Get the Enumerable.Contains method and make it generic for the property type
            var containsMethod = typeof(Enumerable)
                .GetMethods()
                .First(m => m.Name == "Contains" && m.GetParameters().Length == 2)
                .MakeGenericMethod(propertyType);

            // Create the Contains expression (collection.Contains(t.PropertyName))
            var containsExpression = Expression.Call(null, containsMethod, collection, property);

            // Build and return the lambda expression (t => collection.Contains(t.PropertyName))
            return Expression.Lambda<Func<T, bool>>(containsExpression, parameter);
        }

        public static Expression<Func<T, bool>> BuildNotInExpression<T>(Filter filter)
        {
            // Create a parameter expression (e.g., 't' => t.Property)
            var parameter = Expression.Parameter(typeof(T), "t");

            // Get the property expression (t.PropertyName)
            var property = Expression.Property(parameter, filter.Field);

            // Get the type of the property
            var propertyType = property.Type;

            // Convert the filter value into a collection of the correct type (filter.Value should be an array or list)
            var filterValues = ((IEnumerable)filter.Value).Cast<object>()
                              .Select(value => Convert.ChangeType(value, propertyType))
                              .ToArray();

            // Create a constant expression for the collection
            var collection = Expression.Constant(filterValues);

            // Get the Enumerable.Contains method and make it generic for the property type
            var containsMethod = typeof(Enumerable)
                .GetMethods()
                .First(m => m.Name == "Contains" && m.GetParameters().Length == 2)
                .MakeGenericMethod(propertyType);

            // Create the Contains expression (collection.Contains(t.PropertyName))
            var containsExpression = Expression.Call(null, containsMethod, collection, property);

            // Negate the Contains expression to implement Not In (collection does not contain t.PropertyName)
            var notInExpression = Expression.Not(containsExpression);

            // Build and return the lambda expression (t => !collection.Contains(t.PropertyName))
            return Expression.Lambda<Func<T, bool>>(notInExpression, parameter);
        }


        /// -----------------String Operators (6) <summary>--------------------


        /// <summary>
        /// String Operators (6)
        /// </summary>
        /// <returns></returns>
        public static Expression<Func<T, bool>> BuildContainsIgnoreCaseExpression<T>(Filter filter)
        {
            // Create a parameter expression (e.g., 't' => t.Property)
            var parameter = Expression.Parameter(typeof(T), "t");

            // Get the property expression (t.PropertyName)
            var property = Expression.Property(parameter, filter.Field);

            // Ensure the property is of type string
            if (property.Type != typeof(string))
            {
                throw new ArgumentException("Property must be of type string for a 'contains' operation.");
            }

            // Create a constant expression for the filter value (the string to search for, converted to lowercase)
            var searchValue = Expression.Constant(filter.Value.ToString().ToLower(), typeof(string));

            // Get the String.IndexOf method (for case-insensitive search)
            var indexOfMethod = typeof(string).GetMethod("IndexOf", new[] { typeof(string), typeof(StringComparison) });

            // Create the expression for case-insensitive IndexOf (t.PropertyName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase))
            var indexOfExpression = Expression.Call(
                property,
                indexOfMethod,
                searchValue,
                Expression.Constant(StringComparison.OrdinalIgnoreCase)
            );

            // Check if IndexOf returns a value greater than or equal to 0, meaning the substring was found
            var containsExpression = Expression.GreaterThanOrEqual(indexOfExpression, Expression.Constant(0));

            // Build and return the lambda expression (t => t.PropertyName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0)
            return Expression.Lambda<Func<T, bool>>(containsExpression, parameter);
        }

        public static Expression<Func<T, bool>> BuildNotContainsIgnoreCaseExpression<T>(Filter filter)
        {
            // Create a parameter expression (e.g., 't' => t.Property)
            var parameter = Expression.Parameter(typeof(T), "t");

            // Get the property expression (t.PropertyName)
            var property = Expression.Property(parameter, filter.Field);

            // Ensure the property is of type string
            if (property.Type != typeof(string))
            {
                throw new ArgumentException("Property must be of type string for a 'contains' operation.");
            }

            // Create a constant expression for the filter value (the string to search for, converted to lowercase)
            var searchValue = Expression.Constant(filter.Value.ToString().ToLower(), typeof(string));

            // Get the String.IndexOf method (for case-insensitive search)
            var indexOfMethod = typeof(string).GetMethod("IndexOf", new[] { typeof(string), typeof(StringComparison) });

            // Create the expression for case-insensitive IndexOf (t.PropertyName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase))
            var indexOfExpression = Expression.Call(
                property,
                indexOfMethod,
                searchValue,
                Expression.Constant(StringComparison.OrdinalIgnoreCase)
            );

            // Check if IndexOf returns -1, meaning the substring was not found
            var notContainsExpression = Expression.Equal(indexOfExpression, Expression.Constant(-1));

            // Build and return the lambda expression (t => t.PropertyName.IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) == -1)
            return Expression.Lambda<Func<T, bool>>(notContainsExpression, parameter);
        }

        public static Expression<Func<T, bool>> BuildContainsCaseSensitiveExpression<T>(Filter filter)
        {
            // Create a parameter expression (e.g., 't' => t.Property)
            var parameter = Expression.Parameter(typeof(T), "t");

            // Get the property expression (t.PropertyName)
            var property = Expression.Property(parameter, filter.Field);

            // Ensure the property is of type string
            if (property.Type != typeof(string))
            {
                throw new ArgumentException("Property must be of type string for a 'contains' operation.");
            }

            // Create a constant expression for the filter value (the string to search for)
            var searchValue = Expression.Constant(filter.Value.ToString(), typeof(string));

            // Get the String.Contains method (case-sensitive by default)
            var containsMethod = typeof(string).GetMethod("Contains", new[] { typeof(string) });

            // Create the Contains expression (t.PropertyName.Contains(searchValue))
            var containsExpression = Expression.Call(property, containsMethod, searchValue);

            // Build and return the lambda expression (t => t.PropertyName.Contains(searchValue))
            return Expression.Lambda<Func<T, bool>>(containsExpression, parameter);
        }

        public static Expression<Func<T, bool>> BuildNotContainsCaseSensitiveExpression<T>(Filter filter)
        {
            // Create a parameter expression (e.g., 't' => t.Property)
            var parameter = Expression.Parameter(typeof(T), "t");

            // Get the property expression (t.PropertyName)
            var property = Expression.Property(parameter, filter.Field);

            // Ensure the property is of type string
            if (property.Type != typeof(string))
            {
                throw new ArgumentException("Property must be of type string for a 'contains' operation.");
            }

            // Create a constant expression for the filter value (the string to search for)
            var searchValue = Expression.Constant(filter.Value.ToString(), typeof(string));

            // Get the String.Contains method (case-sensitive by default)
            var containsMethod = typeof(string).GetMethod("Contains", new[] { typeof(string) });

            // Create the Contains expression (t.PropertyName.Contains(searchValue))
            var containsExpression = Expression.Call(property, containsMethod, searchValue);

            // Negate the Contains expression to implement "does not contain"
            var notContainsExpression = Expression.Not(containsExpression);

            // Build and return the lambda expression (t => !t.PropertyName.Contains(searchValue))
            return Expression.Lambda<Func<T, bool>>(notContainsExpression, parameter);
        }

        public static Expression<Func<T, bool>> BuildStartsWithExpression<T>(Filter filter)
        {
            // Create a parameter expression (e.g., 't' => t.Property)
            var parameter = Expression.Parameter(typeof(T), "t");

            // Get the property expression (t.PropertyName)
            var property = Expression.Property(parameter, filter.Field);

            // Ensure the property is of type string
            if (property.Type != typeof(string))
            {
                throw new ArgumentException("Property must be of type string for a 'starts with' operation.");
            }

            // Create a constant expression for the filter value (the string to match the start)
            var searchValue = Expression.Constant(filter.Value.ToString(), typeof(string));

            // Get the String.StartsWith method
            var startsWithMethod = typeof(string).GetMethod("StartsWith", new[] { typeof(string) });

            // Create the StartsWith expression (t.PropertyName.StartsWith(searchValue))
            var startsWithExpression = Expression.Call(property, startsWithMethod, searchValue);

            // Build and return the lambda expression (t => t.PropertyName.StartsWith(searchValue))
            return Expression.Lambda<Func<T, bool>>(startsWithExpression, parameter);
        }

        public static Expression<Func<T, bool>> BuildEndsWithExpression<T>(Filter filter)
        {
            // Create a parameter expression (e.g., 't' => t.Property)
            var parameter = Expression.Parameter(typeof(T), "t");

            // Get the property expression (t.PropertyName)
            var property = Expression.Property(parameter, filter.Field);

            // Ensure the property is of type string
            if (property.Type != typeof(string))
            {
                throw new ArgumentException("Property must be of type string for an 'ends with' operation.");
            }

            // Create a constant expression for the filter value (the string to match the end)
            var searchValue = Expression.Constant(filter.Value.ToString(), typeof(string));

            // Get the String.EndsWith method
            var endsWithMethod = typeof(string).GetMethod("EndsWith", new[] { typeof(string) });

            // Create the EndsWith expression (t.PropertyName.EndsWith(searchValue))
            var endsWithExpression = Expression.Call(property, endsWithMethod, searchValue);

            // Build and return the lambda expression (t => t.PropertyName.EndsWith(searchValue))
            return Expression.Lambda<Func<T, bool>>(endsWithExpression, parameter);
        }

        /// -----------------Null Operators (3) <summary>--------------------


        /// <summary>
        /// null: Is null
        //  Example: {"field": "deletedAt", "operator": "null"}
        //  Matches records where the deletedAt field is null
        /// </summary>
        public static Expression<Func<T, bool>> BuildIsNullExpression<T>(Filter filter)
        {
            // Create a parameter expression (e.g., 't' => t.Property)
            var parameter = Expression.Parameter(typeof(T), "t");

            // Get the property expression (t.PropertyName)
            var property = Expression.Property(parameter, filter.Field);

            // Create a constant expression representing null
            var nullConstant = Expression.Constant(null, property.Type);

            // Create the expression to check if the property is null (t.PropertyName == null)
            var isNullExpression = Expression.Equal(property, nullConstant);

            // Build and return the lambda expression (t => t.PropertyName == null)
            return Expression.Lambda<Func<T, bool>>(isNullExpression, parameter);
        }

        /// <summary>
        ///nnull: Is not null
        ///mple: {"field": "lastLoginDate", "operator": "nnull"}
        ///ches records where the lastLoginDate field is not null
        /// </summary>
        public static Expression<Func<T, bool>> BuildIsNotNullExpression<T>(Filter filter)
        {
            // Create a parameter expression (e.g., 't' => t.Property)
            var parameter = Expression.Parameter(typeof(T), "t");

            // Get the property expression (t.PropertyName)
            var property = Expression.Property(parameter, filter.Field);

            // Create a constant expression representing null
            var nullConstant = Expression.Constant(null, property.Type);

            // Create the expression to check if the property is not null (t.PropertyName != null)
            var isNotNullExpression = Expression.NotEqual(property, nullConstant);

            // Build and return the lambda expression (t => t.PropertyName != null)
            return Expression.Lambda<Func<T, bool>>(isNotNullExpression, parameter);
        }

        /// <summary>
        //between: Between two values(inclusive)
        //Example: {"field": "createDate", "operator": "between", "value": ["2023-01-01", "2023-12-31"]}   
        //Matches records where the createDate is between January 1, 2023, and December 31, 2023 (inclusive)
        /// </summary>
        public static Expression<Func<T, bool>> BuildBetweenExpression<T>(Filter filter)
        {
            // Create a parameter expression (e.g., 't' => t.Property)
            var parameter = Expression.Parameter(typeof(T), "t");

            // Get the property expression (t.PropertyName)
            var property = Expression.Property(parameter, filter.Field);

            // Ensure the property is of a type that supports comparison (DateTime, int, etc.)
            if (property.Type != typeof(DateTime) && property.Type != typeof(int) && property.Type != typeof(double) && property.Type != typeof(decimal))
            {
                throw new ArgumentException("Property must be of type DateTime, int, double, or decimal for a 'between' operation.");
            }

            // Convert the filter values into the correct type
            var lowerBoundValue = Convert.ChangeType(((IEnumerable)filter.Value).Cast<object>().First(), property.Type);
            var upperBoundValue = Convert.ChangeType(((IEnumerable)filter.Value).Cast<object>().Skip(1).First(), property.Type);

            // Create constant expressions for the lower and upper bounds
            var lowerBound = Expression.Constant(lowerBoundValue, property.Type);
            var upperBound = Expression.Constant(upperBoundValue, property.Type);

            // Create the expressions for the comparisons
            var greaterThanOrEqual = Expression.GreaterThanOrEqual(property, lowerBound);
            var lessThanOrEqual = Expression.LessThanOrEqual(property, upperBound);

            // Combine the conditions with AndAlso
            var betweenExpression = Expression.AndAlso(greaterThanOrEqual, lessThanOrEqual);

            // Build and return the lambda expression (t => t.Property >= lowerBound && t.Property <= upperBound)
            return Expression.Lambda<Func<T, bool>>(betweenExpression, parameter);
        }















        public static IQueryable<Tenant> ApplySorting(IQueryable<Tenant> query, SortOption sort)
        {
            if (string.Equals(sort.Order, "asc", StringComparison.OrdinalIgnoreCase))
            {
                query = query.OrderByDynamic(sort.Field);
            }
            else if (string.Equals(sort.Order, "desc", StringComparison.OrdinalIgnoreCase))
            {
                query = query.OrderByDescendingDynamic(sort.Field);
            }

            return query;
        }



        public static IQueryable<T> OrderByDynamic<T>(this IQueryable<T> query, string orderByProperty)
        {
            return query.OrderBy(e => EF.Property<object>(e, orderByProperty));
        }

        public static IQueryable<T> OrderByDescendingDynamic<T>(this IQueryable<T> query, string orderByProperty)
        {
            return query.OrderByDescending(e => EF.Property<object>(e, orderByProperty));
        }

        public static IQueryable<T> ApplySorting<T>(IQueryable<T> query, SortOption sort)
        {
            if (string.IsNullOrWhiteSpace(sort?.Field))
                return query;

            if (string.Equals(sort.Order, "asc", StringComparison.OrdinalIgnoreCase))
            {
                return query.OrderByDynamic(sort.Field);
            }
            else if (string.Equals(sort.Order, "desc", StringComparison.OrdinalIgnoreCase))
            {
                return query.OrderByDescendingDynamic(sort.Field);
            }

            return query;
        }

        
    }
}
