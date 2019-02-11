using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RnD.FilterDescriptorToLinqConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var operations = GetOperationList();

            ParameterExpression operationVariableExpression = Expression.Variable(typeof(Operation));
            MemberExpression memberExpression = Expression.PropertyOrField(operationVariableExpression, "Name");
            var binarryExpression = Expression.Equal(memberExpression, Expression.Constant("Operation_10"));
            var lyamdaExpression = Expression.Lambda<Func<Operation, bool>>(binarryExpression, operationVariableExpression);
            var filter = lyamdaExpression.Compile();

            var result = operations.Where(filter);

            Console.ReadKey();
        }

        public static List<Operation> GetOperationList()
        {
            var result = new List<Operation>();

            for (int i = 1; i < 1000; i++)
            {
                result.Add(new Operation()
                {
                    Id = i
                    , Name = String.Format("Operation_{0}", i)
                    , Description = String.Format("Description_{0}", i)
                });
            }

            return result;
        }
    }
}
