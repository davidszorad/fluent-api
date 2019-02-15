using System.Collections.Generic;

namespace FluentApiDemo
{
    public class Fluent
    {
        public List<int> DataList { get; }
        
        public Fluent()
        {
            DataList = new List<int>();
            ParameterBuilder.Fill(DataList).WithString("999");
            ParameterBuilder.Fill(DataList).WithInt(123);
            ParameterBuilder.Fill(DataList).WithString("444");
        }
        
        private static class ParameterBuilder
        {
            public static ParameterBuilderCore Fill(List<int> parameters)
            {
                return new ParameterBuilderCore(parameters);
            }
            
            public class ParameterBuilderCore
            {
                private readonly List<int> parameters;

                //public List<int> Parameters => this.parameters;

                public ParameterBuilderCore(List<int> parameters)
                {
                    this.parameters = parameters;
                }
                
                public ParameterBuilderCore WithString(string input)
                {
                    this.parameters.Add(int.Parse(input));
                
                    return this;
                }
                
                public ParameterBuilderCore WithInt(int input)
                {
                    this.parameters.Add(input);
                
                    return this;
                }
            }
        }
    }
}