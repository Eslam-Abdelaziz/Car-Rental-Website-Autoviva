using AdminPanel.Models;
using RJCodeAdvance.RJControls;

namespace AdminPanel.Extenstions
{
	public static class ComboBoxExtenstions
	{
		public static void SelectItem<T>(this RJComboBox box,T obj) where T : BaseEntity
		{
			foreach (T item in box.Items) 
			{
				if (item.Id == obj.Id) 
				{
					box.SelectedItem = item;
					break;
				}
			}
		}
	}
}
