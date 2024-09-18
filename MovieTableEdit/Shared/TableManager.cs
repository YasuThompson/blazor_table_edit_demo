using System;
using System.Collections.Generic;


namespace MovieTableEdit.Shared.TableManager
{
    public class TableIndexManager
    {
        private HashSet<int> selectedIndexes = new HashSet<int>();

        // Add an index to the set
        public void AddIndex(int index)
        {
            selectedIndexes.Add(index);
        }

        // Remove an index from the set
        public void RemoveIndex(int index)
        {
            selectedIndexes.Remove(index);
        }

        // Check if an index is in the set
        public bool ContainsIndex(int index)
        {
            return selectedIndexes.Contains(index);
        }

        // Get all selected indexes
        public IEnumerable<int> GetAllIndexes()
        {
            return selectedIndexes;
        }
    }

    public static class SharedFunctions
    {
         public static string GetDimDictValue(int key, Dictionary<int, string> dim_dict)
        {
            if (dim_dict != null && dim_dict.ContainsKey(key))
            {
                return dim_dict[key];
            }
            return "Value not found from the dimension table";
        }
    }
   


}
