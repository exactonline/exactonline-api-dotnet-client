using ExactOnline.Client.Sdk.Enums;
using ExactOnline.Client.Sdk.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.Helpers
{
    public class ExactOnlineQuery<T>
    {
        private readonly IController<T> _controller;
        private readonly List<string> _and;

        private string _select;
        private string _skip;
        private string _expand;
        private string _top;
        private string _orderby;
        private string _where;
        private string _skipToken;

        /// <summary>
        /// Private constructor, can only be called by static For()
        /// </summary>
        public ExactOnlineQuery(IController<T> controller)
        {
            if (controller == null) { throw new ArgumentException("Instance of type Controller cannot be null"); }
            _and = new List<string>();
            _controller = controller;
        }

        /// <summary>
        /// Creates a 'where' clause for the query
        /// </summary>
        public ExactOnlineQuery<T> Where<TProperty>(Expression<Func<T, TProperty>> property, TProperty value, OperatorEnum @operator = OperatorEnum.Eq)
        {
            return Where($"{TransformExpressionToODataFormat(property.Body)}+{@operator.ToString().ToLower()}+{ToODataParameter(value)}");
        }

        /// <summary>
        /// Creates a 'where' clause for the query
        /// </summary>
        public ExactOnlineQuery<T> Where(string filter)
        {
            if (string.IsNullOrEmpty(filter)) throw new ArgumentException("Query 'where' operator cannot be empty");
            _where = "$filter=" + filter;
            return this;
        }

        /// <summary>
        /// Appends an 'and' clause to the query. This method can't be called before a where clause is set.
        /// </summary>
        public ExactOnlineQuery<T> And<TProperty>(Expression<Func<T, TProperty>> property, TProperty value, OperatorEnum @operator = OperatorEnum.Eq)
        {
            return And($"{TransformExpressionToODataFormat(property.Body)}+{@operator.ToString().ToLower()}+{ToODataParameter(value)}");
        }

        /// <summary>
        /// Appends an 'and' clause to the query. This method can't be called before a where clause is set.
        /// </summary>
        public ExactOnlineQuery<T> And(string and)
        {
            if (string.IsNullOrEmpty(and)) throw new ArgumentException("Query 'and' operator cannot be empty");
            if (string.IsNullOrEmpty(_where)) throw new ArgumentException("Query 'and' operator cannot be used before 'where' operator is set");

            _and.Add(and);
            return this;
        }

        /// <summary>
        /// Builds query using the _where and _and properties
        /// </summary>
        private string CreateODataQuery(bool selectIsMandatory)
        {
            var queryParts = new List<string>();

            if (!string.IsNullOrEmpty(_where))
            {
                if (_and != null && _and.Count > 0)
                {
                    _where += string.Format("+and+{0}", string.Join("+and+", _and));
                }
                queryParts.Add(_where);
            }

            // Add $select
            if (!string.IsNullOrEmpty(_select))
            {
                queryParts.Add(_select);
            }
            else if (selectIsMandatory)
            {
                throw new Exception("You have to specify which fields you want to select");
            }

            // Add $skip
            if (!string.IsNullOrEmpty(_skip))
            {
                queryParts.Add(_skip);
            }

            // Add $expand
            if (!string.IsNullOrEmpty(_expand))
            {
                queryParts.Add(_expand);
            }

            // Add top
            if (!string.IsNullOrEmpty(_top))
            {
                queryParts.Add(_top);
            }

            // Add $skipToken
            if (!string.IsNullOrEmpty(_skipToken))
            {
                queryParts.Add(_skipToken);
            }

            // Add orderby
            if (!string.IsNullOrEmpty(_orderby))
            {
                queryParts.Add(_orderby);
            }

            string query = string.Join("&", queryParts);

            return query;
        }

        /// <summary>
        /// Specify the fields to get from the API
        /// </summary>
        /// <param name="property">The property to select</param>
        public ExactOnlineQuery<T> Select(params Expression<Func<T, object>>[] property)
        {
            return Select(fields: property.Select(x => TransformExpressionToODataFormat(x.Body)).ToArray());
        }

        /// <summary>
        /// Specify the field(s) to get from the API
        /// </summary>
        /// <param name="fields">The field(s) to get</param>
        public ExactOnlineQuery<T> Select(params string[] fields)
        {
            if (fields != null && fields.Length > 0)
            {
                string select = String.Join(",", fields);

                if (String.IsNullOrEmpty(_select))
                    _select = "$select=" + select;
                else
                    _select += ',' + select;
            }
            return this;
        }

        /// <summary>
        /// Specify the number of records to get from the API
        /// </summary>
        /// <param name="top"></param>
        public ExactOnlineQuery<T> Top(int top)
        {
            _top = string.Format("$top={0}", top);
            return this;
        }

        /// <summary>
        /// Paging: Specify the number of records that must be skipped
        /// </summary>
        /// <param name="skip"></param>
        public ExactOnlineQuery<T> Skip(int skip)
        {
            _skip = string.Format("$skip={0}", skip);
            return this;
        }

        /// <summary>
        /// Paging: Specify the skip token
        /// </summary>
        /// <param name="skipToken"></param>
        private ExactOnlineQuery<T> FormulateSkipToken(string skipToken)
        {
            if (!string.IsNullOrEmpty(skipToken))
            {
                _skipToken = string.Format("$skiptoken={0}", skipToken);
            }
            return this;
        }


        /// <summary>
        /// Specify the field to order by
        /// </summary>
        /// <param name="orderby"></param>
        public ExactOnlineQuery<T> OrderBy(Expression<Func<T, object>> orderby)
        {
            return OrderBy(TransformExpressionToODataFormat(orderby.Body));
        }

        /// <summary>
        /// Specify the field(s) to order by
        /// </summary>
        /// <param name="orderby"></param>
        public ExactOnlineQuery<T> OrderBy(params string[] orderby)
        {
            if (orderby != null && orderby.Length > 0)
            {
                string orderbyclause = String.Join(",", orderby);

                if (String.IsNullOrEmpty(_orderby))
                    _orderby = "$orderby=" + orderbyclause;
                else
                    _orderby += ',' + orderbyclause;
            }
            return this;
        }

        /// <summary>
        /// Field to Expand with coupled entities
        /// </summary>
        public ExactOnlineQuery<T> Expand(string expand)
        {
            _controller.RegistrateLinkedEntityField(expand);
            _expand = "$expand=" + expand;
            return this;
        }

        /// <summary>
        /// Count the amount of entities in the the entity
        /// </summary>
        public int Count()
        {
            return _controller.Count(CreateODataQuery(false));
        }

        /// <summary>
        /// Count the amount of entities in the the entity
        /// </summary>
        public Task<int> CountAsync()
        {
            return _controller.CountAsync(CreateODataQuery(false));
        }


        /// <summary>
        /// Returns a List of entities using the specified query
        /// </summary>
        public List<T> Get()
        {
            string skipToken = string.Empty;
            return Get(ref skipToken);
        }

        /// <summary>
        /// Returns a List of entities using the specified query.
        /// </summary>
        /// <param name="skipToken">The variable to store the skiptoken in</param>
        public List<T> Get(ref string skiptoken)
        {
            FormulateSkipToken(skiptoken);
            return _controller.Get(CreateODataQuery(true), ref skiptoken);
        }

        /// <summary>
        /// Returns a List of entities using the specified query.
        /// </summary>
        /// <param name="skipToken">The variable to store the skiptoken in</param>
        public Task<Models.ApiList<T>> GetAsync(string skiptoken = "")
        {
            FormulateSkipToken( skiptoken );
            return _controller.GetAsync(CreateODataQuery(true));
        }

        /// <summary>
        /// Returns one instance of an entity using the specified identifier
        /// </summary>
        public T GetEntity(string identifier)
        {
            if (string.IsNullOrEmpty(identifier)) throw new ArgumentException("Get entity: Identifier cannot be empty");
            string query = CreateODataQuery(false);
            return _controller.GetEntity(identifier, query);
        }

        /// <summary>
        /// Returns one instance of an entity using the specified identifier
        /// </summary>
        public Task<T> GetEntityAsync(string identifier)
        {
            if( string.IsNullOrEmpty( identifier ) ) throw new ArgumentException( "Get entity: Identifier cannot be empty" );
            string query = CreateODataQuery( false );
            return _controller.GetEntityAsync(identifier, query);
        }

        /// <summary>
        /// Returns one instance of an entity using the specified identifier
        /// </summary>
        public T GetEntity(Guid identifier)
        {
            if (identifier == Guid.Empty) throw new ArgumentException("Get entity: Identifier cannot be empty");
            string query = CreateODataQuery(false);
            return _controller.GetEntity(identifier.ToString(), query);
        }

        /// <summary>
        /// Returns one instance of an entity using the specified identifier
        /// </summary>
        public Task<T> GetEntityAsync(Guid identifier)
        {
            if( identifier == Guid.Empty ) throw new ArgumentException( "Get entity: Identifier cannot be empty" );
            string query = CreateODataQuery( false );
            return _controller.GetEntityAsync(identifier.ToString(), query);
        }

        /// <summary>
        /// Returns one instance of an entity using the specified identifier
        /// </summary>
        public T GetEntity(int identifier)
        {
            string query = CreateODataQuery(false);
            return _controller.GetEntity(identifier.ToString(CultureInfo.InvariantCulture), query);
        }

        /// <summary>
        /// Returns one instance of an entity using the specified identifier
        /// </summary>
        public Task<T> GetEntityAsync(int identifier)
        {
            string query = CreateODataQuery( false );
            return _controller.GetEntityAsync(identifier.ToString( CultureInfo.InvariantCulture), query );
        }

        /// <summary>
        /// Updates the specified entity
        /// </summary>
        public Boolean Update(T entity)
        {
            if (entity == null) throw new ArgumentException("Update entity: Entity cannot be null");
            return _controller.Update(entity);
        }

        /// <summary>
        /// Updates the specified entity
        /// </summary>
        public Task<Boolean> UpdateAsync(T entity)
        {
            if( entity == null ) throw new ArgumentException( "Update entity: Entity cannot be null" );
            return _controller.UpdateAsync(entity);
        }

        /// <summary>
        /// Deletes the specified entity
        /// </summary>
        public Boolean Delete(T entity)
        {
            if (entity == null) throw new ArgumentException("Delete entity: Entity cannot be null");
            return _controller.Delete(entity);
        }

        /// <summary>
        /// Deletes the specified entity
        /// </summary>
        public Task<Boolean> DeleteAsync(T entity)
        {
            if( entity == null ) throw new ArgumentException( "Delete entity: Entity cannot be null" );
            return _controller.DeleteAsync(entity);
        }

        /// <summary>
        /// Inserts the specified entity into Exact Online
        /// </summary>
        public Boolean Insert(ref T entity)
        {
            if (entity == null) throw new ArgumentException("Insert entity: Entity cannot be null");
            return _controller.Create(ref entity);
        }

        /// <summary>
        /// Inserts the specified entity into Exact Online
        /// </summary>
        public Task<T> InsertAsync(T entity)
        {
            if( entity == null ) throw new ArgumentException( "Insert entity: Entity cannot be null" );
            return _controller.CreateAsync(entity);
        }

        /// <summary>
        /// Transforms a given C# expression to an OData-compliant expression
        /// </summary>
        string TransformExpressionToODataFormat(Expression e)
        {
            MemberExpression me = null;

            if (e is MemberExpression)
                me = e as MemberExpression;
            else if (e is UnaryExpression)
                me = ((UnaryExpression)e).Operand as MemberExpression;

            if (me != null) return me.Member.Name;

            var listArguments = new List<string>();
            var mce = e as MethodCallExpression;

            if (mce == null) throw new ArgumentException($"Invalid expression '{e}': Lambda expression should resolve a property on model type '{nameof(T)}' (with optional extension method calls).", nameof(e));

            foreach (var argument in mce.Arguments)
            {
                if (argument is ConstantExpression)
                {
                    var ce = argument as ConstantExpression;
                    listArguments.Add(ToODataParameter(ce.Value));
                }
            }

            string arguments = null;
            if (listArguments.Count > 0) arguments = "," + String.Join(",", listArguments);

            return $"{mce.Method.Name.ToLower()}({TransformExpressionToODataFormat(mce.Object)}{arguments})";
        }

        /// <summary>
        /// Formats any given value to it's OData-compliant string representation.
        /// </summary>
        string ToODataParameter(object value)
        {
            string _value = null;

            if (value != null)
            {
                var type = value.GetType();
                type = Nullable.GetUnderlyingType(type) ?? type;

                if (type == typeof(string) || type == typeof(char))
                    _value = $"'{value}'";
                else if (type == typeof(Guid))
                    _value = $"guid'{value}'";
                else if (type == typeof(DateTime))
                    _value = $"datetime'{value:s}'";
                else if (type == typeof(bool))
                    _value = value.ToString().ToLower();
                else
                    _value = value.ToString();
            }

            return _value;
        }
    }
}
