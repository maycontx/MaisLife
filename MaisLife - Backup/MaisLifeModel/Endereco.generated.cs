#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using MaisLifeModel;

namespace MaisLifeModel	
{
	[System.Serializable()]
	public partial class Endereco : System.Runtime.Serialization.ISerializable
	{
		private int _id;
		public virtual int Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		
		private int? _usuario;
		public virtual int? Usuario
		{
			get
			{
				return this._usuario;
			}
			set
			{
				this._usuario = value;
			}
		}
		
		private string _pais;
		public virtual string Pais
		{
			get
			{
				return this._pais;
			}
			set
			{
				this._pais = value;
			}
		}
		
		private string _estado;
		public virtual string Estado
		{
			get
			{
				return this._estado;
			}
			set
			{
				this._estado = value;
			}
		}
		
		private string _cidade;
		public virtual string Cidade
		{
			get
			{
				return this._cidade;
			}
			set
			{
				this._cidade = value;
			}
		}
		
		private int? _bairro;
		public virtual int? Bairro
		{
			get
			{
				return this._bairro;
			}
			set
			{
				this._bairro = value;
			}
		}
		
		private string _rua;
		public virtual string Rua
		{
			get
			{
				return this._rua;
			}
			set
			{
				this._rua = value;
			}
		}
		
		private string _numero;
		public virtual string Numero
		{
			get
			{
				return this._numero;
			}
			set
			{
				this._numero = value;
			}
		}
		
		private string _cep;
		public virtual string Cep
		{
			get
			{
				return this._cep;
			}
			set
			{
				this._cep = value;
			}
		}
		
		private Bairro _bairro1;
		public virtual Bairro Bairro1
		{
			get
			{
				return this._bairro1;
			}
			set
			{
				this._bairro1 = value;
			}
		}
		
		private Usuario _usuario1;
		public virtual Usuario Usuario1
		{
			get
			{
				return this._usuario1;
			}
			set
			{
				this._usuario1 = value;
			}
		}
		
		private IList<Usuario_externo> _usuario_externos = new List<Usuario_externo>();
		public virtual IList<Usuario_externo> Usuario_externos
		{
			get
			{
				return this._usuario_externos;
			}
            set
			{
                this._usuario_externos = value;
			}
		}
		
		private IList<Pedido> _pedidos = new List<Pedido>();
		public virtual IList<Pedido> Pedidos
		{
			get
			{
				return this._pedidos;
			}
            set
            {
                this._pedidos = value;
            }
		}
		
		#region ISerializable Implementation
		
		public Endereco()
		{
		}
		
		protected Endereco(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			this.Id = info.GetInt32("Id");
			this.Usuario = (int?)info.GetValue("Usuario", typeof(int?));
			this.Pais = info.GetString("Pais");
			this.Estado = info.GetString("Estado");
			this.Cidade = info.GetString("Cidade");
			this.Bairro = (int?)info.GetValue("Bairro", typeof(int?));
			this.Rua = info.GetString("Rua");
			this.Numero = info.GetString("Numero");
			this.Cep = info.GetString("Cep");
			CustomizeDeserializationProcess(info, context);
		}
		
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			info.AddValue("Id", this.Id, typeof(int));
			info.AddValue("Usuario", this.Usuario, typeof(int?));
			info.AddValue("Pais", this.Pais, typeof(string));
			info.AddValue("Estado", this.Estado, typeof(string));
			info.AddValue("Cidade", this.Cidade, typeof(string));
			info.AddValue("Bairro", this.Bairro, typeof(int?));
			info.AddValue("Rua", this.Rua, typeof(string));
			info.AddValue("Numero", this.Numero, typeof(string));
			info.AddValue("Cep", this.Cep, typeof(string));
			CustomizeSerializationProcess(info, context);
		}
		
		partial void CustomizeSerializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		partial void CustomizeDeserializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		#endregion
	}
}
#pragma warning restore 1591
