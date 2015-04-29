﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageTranslator.Definition
{
	class Definitions
	{
		public List<EnumDef> Enums = new List<EnumDef>();

		public List<ClassDef> Classes = new List<ClassDef>();
	}

	class EnumDef
	{
		public string Name = string.Empty;
		public string Brief = string.Empty;
		public List<EnumMemberDef> Members = new List<EnumMemberDef>();

		public bool IsDefinedBySWIG = false;
	}

	class EnumMemberDef
	{
		public string Name = string.Empty;
		public string Brief = string.Empty;
	}

	class ClassDef
	{
		public string Name = string.Empty;
		public string Brief = string.Empty;
	
		public override string ToString()
		{
			return string.Format("ClassDef {0}", Name);
		}

		public bool IsDefinedBySWIG = false;
	}
}