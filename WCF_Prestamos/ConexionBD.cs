using System;
using System.Configuration;

public class Class1
{
	public Class1()
	{
		public static string obtenerCadenaConexion()
        {
			return ConfigurationManager.ConectionsStrings["PrestamosBD"].ToString();
        }
	}
}
