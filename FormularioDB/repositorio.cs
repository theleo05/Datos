using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormularioDB
{
	public class repositorio
	{
		private ConFormu _context;

		public repositorio()
		{
			_context = new ConFormu();
		}

		public List <persona> GetPersonas()
		{
			List<persona> listapersonas = _context.persona.ToList();

			return listapersonas;
		}
		
	}
}