using System;

namespace DXCTechnology.Belcorp.ePlanning.EntityLayer
{
	public class CategoriaModel
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CategoriaModel class.
		/// </summary>
		public CategoriaModel()
		{
		}

		/// <summary>
		/// Initializes a new instance of the CategoriaModel class.
		/// </summary>
		public CategoriaModel(string Descripcion, string Abreviatura, string UsuarioCreacion, DateTime FechaCreacion, string UsuarioModificacion, DateTime FechaModificacion)
		{
			this.Descripcion = Descripcion;
			this.Abreviatura = Abreviatura;
			this.UsuarioCreacion = UsuarioCreacion;
			this.FechaCreacion = FechaCreacion;
			this.UsuarioModificacion = UsuarioModificacion;
			this.FechaModificacion = FechaModificacion;
		}

		/// <summary>
		/// Initializes a new instance of the CategoriaModel class.
		/// </summary>
		public CategoriaModel(int IdCategoria, string Descripcion, string Abreviatura, string UsuarioCreacion, DateTime FechaCreacion, string UsuarioModificacion, DateTime FechaModificacion)
		{
			this.IdCategoria = IdCategoria;
			this.Descripcion = Descripcion;
			this.Abreviatura = Abreviatura;
			this.UsuarioCreacion = UsuarioCreacion;
			this.FechaCreacion = FechaCreacion;
			this.UsuarioModificacion = UsuarioModificacion;
			this.FechaModificacion = FechaModificacion;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the IdCategoria value. 
		/// </summary>
		public int IdCategoria { get; set; }

		/// <summary>
		/// Gets or sets the Descripcion value. 
		/// </summary>
		public string Descripcion { get; set; }

		/// <summary>
		/// Gets or sets the Abreviatura value. 
		/// </summary>
		public string Abreviatura { get; set; }

		/// <summary>
		/// Gets or sets the UsuarioCreacion value. 
		/// </summary>
		public string UsuarioCreacion { get; set; }

		/// <summary>
		/// Gets or sets the FechaCreacion value. 
		/// </summary>
		public DateTime FechaCreacion { get; set; }

		/// <summary>
		/// Gets or sets the UsuarioModificacion value. 
		/// </summary>
		public string UsuarioModificacion { get; set; }

		/// <summary>
		/// Gets or sets the FechaModificacion value. 
		/// </summary>
		public DateTime FechaModificacion { get; set; }

		#endregion
	}
}
