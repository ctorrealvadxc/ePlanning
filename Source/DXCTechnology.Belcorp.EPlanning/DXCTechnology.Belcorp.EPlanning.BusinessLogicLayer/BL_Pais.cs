using System;
using System.Collections.Generic;
using DXCTechnology.Belcorp.ePlanning.DataAccessLayer;
using DXCTechnology.Belcorp.ePlanning.EntityLayer;

namespace DXCTechnology.Belcorp.ePlanning.BusinessLogicLayer
{
	public class BL_Pais
	{
		#region Methods

		/// <summary>
		/// Guarda un registro de la tabla Pais.
		/// </summary>
		public void Insert(PaisModel x_oPaisModel)
		{
			 new DA_Pais().Insert(x_oPaisModel);
		}

		/// <summary>
		/// Actualiza a registro de la tabla Pais.
		/// </summary>
		public void Update(PaisModel x_oPaisModel)
		{
			 new DA_Pais().Update(x_oPaisModel);
		}

		/// <summary>
		/// Elimina un registro de la tabla Pais por su primary key.
		/// </summary>
		public void Delete(byte IdPais)
		{
			 new DA_Pais().Delete(IdPais);
		}

		/// <summary>
		/// Selecciona una registro de la tabla Pais por su primary key.
		/// </summary>
		public PaisModel Select(byte IdPais)
		{
			return new DA_Pais().Select(IdPais);
		}

        /// <summary>
        /// Selecciona una registro de la tabla Pais por su primary key.
        /// </summary>
        public PaisModel SelectByAbreviatura(string Abreviatura)
        {
            return new DA_Pais().SelectByAbreviatura(Abreviatura);
        }

        /// <summary>
        /// Selecciona todos los registro de la tabla Pais.
        /// </summary>
        public List<PaisModel> SelectAll(PaisModel paisModel)
		{
			 return new DA_Pais().SelectAll(paisModel);
		}

		#endregion
	}
}
