using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList // Note: actual namespace depends on the project name.
{
    public class Constants
    {
        public enum Size{
            Empty,
            XS,
            S,
            M,
            L,
            XL
        }

        public enum BoardType{
            ToDo = 1,
            InProgress,
            Done
        }
    }
}