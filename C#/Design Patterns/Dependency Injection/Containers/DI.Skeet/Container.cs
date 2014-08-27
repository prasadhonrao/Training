using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DI.Skeet
{
    public class Container
    {
        Dictionary<Type, Func<object>> registrations = new Dictionary<Type, Func<object>>();

        internal void Register<TKey, TConcreteType>() where TConcreteType : TKey
        {
            registrations[typeof(TKey)] = () => ResolveByType(typeof(TConcreteType));
        }

        private object ResolveByType(Type T)
        {
            var constructor = T.GetConstructors().SingleOrDefault();
            var arguments = constructor.GetParameters().Select(p => Resolve(p.ParameterType)).ToArray();
            return constructor.Invoke(arguments);
        }

        public void Register<T>(T instance)
        {
            registrations[typeof(T)] = () => instance;
        }

        internal TKey Resolve<TKey>()
        {
            return (TKey)Resolve(typeof(TKey));
        }

        internal object Resolve(Type type)
        {
            Func<object> provider;
            if (registrations.TryGetValue(type, out provider))
            {
                return provider();
            }
            return ResolveByType(type);
        }
    }
}
