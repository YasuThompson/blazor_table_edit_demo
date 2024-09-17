using System;
using System.Collections.Generic;


namespace MovieTableEdit.TableManager
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


}
