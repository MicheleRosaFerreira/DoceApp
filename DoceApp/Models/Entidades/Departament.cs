namespace DoceApp.Models.Entidades
{
	public class Departament
	{
		public int DPM_Id { get; set; }
		public string Name { get; set; }
		public string Icon { get; set; }
		public Departament()
		{
			Name= string.Empty;
			Icon= string.Empty;
		}
		public Departament(string name, string icon)
		{
			Name = name;
			Icon = icon;
		}
	}
}
