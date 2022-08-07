using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_4_cs223.model
{
    class save {
        static List<save> saves = new List<save>();
    
        public string number { get; set; }
        public DateTime date { get; set; }
        public string inventoryNumber { get; set; }
        public string objectname { get; set; }
        public string count { get; set; }
        public string price { get; set; }
        public Boolean Availble { get; set; }
        
        public void Save()
        {
            
           
            saves.Add(this);
        }
       static public List<save> getAllSave()
        {
         return saves;
        }

      
    }
}

