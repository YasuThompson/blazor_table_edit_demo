namespace MovieTableEdit.Shared.FilterManager
{
    public class SharedFunctions
    {
        public static Dictionary<string, bool> MakeMultiSelectDict(List<string> optionList)
        {
            Dictionary<string, bool> selection_dict = new Dictionary<string, bool>();

            foreach(string elem in optionList)
            {
                selection_dict[elem] = true;
            }

            return selection_dict;
        }

        public static List<string> GetSelectedOptions(Dictionary<string, bool> _selection_dict)
        {
            List<string> selected_option_list = new List<string>();

            foreach(var kvp in _selection_dict)
            {   
                if(kvp.Value)
                {
                    selected_option_list.Add(kvp.Key);
                }
            }

            return selected_option_list;
        }
    }


}