namespace DoceApp.Models.Entidades
{
	public class Departament
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Icon { get; set; }
		public Confectionery confectionery 	{get;set;}
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
