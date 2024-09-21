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

        public static string GetDimDictValueNested(int key, Dictionary<int, int> inner_dim_dict, Dictionary<int, string> outer_dim_dict)
        {
            try
            {
                return outer_dim_dict[inner_dim_dict[key]];
            }
            catch (Exception ex)
            {
                return "Value not found from the dimension tables"; 
            }
        }

        public static void ToggleRowIndex(int clicked_row_id, TableIndexManager _index_manager)
        {   
            if(_index_manager.ContainsIndex(clicked_row_id))
            {
                _index_manager.RemoveIndex(clicked_row_id);
            }
            else
            {
                _index_manager.AddIndex(clicked_row_id);
            }
        }


        public static string IfDeleteCell(int _row_id, TableIndexManager _index_manager)
        {   

            if(_index_manager.ContainsIndex(_row_id)==true)
            {
                return "selected-row";
            }
            else
            {
                return "dummy";
            }
        }

    }

    
   


}
