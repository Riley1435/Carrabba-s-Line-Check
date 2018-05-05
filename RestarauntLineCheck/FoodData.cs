using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarauntLineCheck
{
   class FoodData : DatabaseConnector
   {
      private string _date;
      private string username;
      private string food;
      private string equipment;

      public FoodData()
      {
         username = "";
         food = "";
      }
      public string Username
      {
         get
         {
            return username;
         }
         set
         {
            username = value;
         }
      }
      public string Food
      {
         get
         {
            return food;
         }
         set
         {
            food = value;
         }
      }
      public string _Date
      {
         get
         {
            return _date;
         }
         set
         {
            _date = value;
         }
      }
        public string Equipment
        {
            get
            {
                return equipment;
            }
            set
            {
                equipment = value;
            }
        }
    }
}
