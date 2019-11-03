using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonExamplex
{
    class Singleton
    {
        private static  Singleton exemplu=new Singleton();
        public int Id
        {
            get; set;
        }
        private Singleton()
        {
            Id =Id+ 1;
        }
        public static Singleton CreareExemplu()
        {
            
            if (exemplu == null)
            {
                exemplu = new Singleton();
            }
            return exemplu;
        }

    }
    
}
