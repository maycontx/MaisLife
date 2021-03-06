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
	public partial class Produto : System.Runtime.Serialization.ISerializable
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
		
		private string _nome;
		public virtual string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				this._nome = value;
			}
		}
		
		private string _descricao;
		public virtual string Descricao
		{
			get
			{
				return this._descricao;
			}
			set
			{
				this._descricao = value;
			}
		}
		
		private decimal _preco;
		public virtual decimal Preco
		{
			get
			{
				return this._preco;
			}
			set
			{
				this._preco = value;
			}
		}
		
		private string _imagem;
		public virtual string Imagem
		{
			get
			{
				return this._imagem;
			}
			set
			{
				this._imagem = value;
			}
		}
		
		private int? _unidade;
		public virtual int? Unidade
		{
			get
			{
				return this._unidade;
			}
			set
			{
				this._unidade = value;
			}
		}
		
		private int _dias_entrega;
		public virtual int Dias_entrega
		{
			get
			{
				return this._dias_entrega;
			}
			set
			{
				this._dias_entrega = value;
			}
		}
		
		private IList<Produto_bairro> _produto_bairros = new List<Produto_bairro>();
		public virtual IList<Produto_bairro> Produto_bairros
		{
			get
			{
				return this._produto_bairros;
			}
            set
            {
                this._produto_bairros = value;
            }
		}
		
		private IList<Carrinho_produto> _carrinho_produtos = new List<Carrinho_produto>();
		public virtual IList<Carrinho_produto> Carrinho_produtos
		{
			get
			{
				return this._carrinho_produtos;
			}
            set
            {
                this._carrinho_produtos = value;
            }
		}
		
		private IList<Devolucao_produto> _devolucao_produtos = new List<Devolucao_produto>();
		public virtual IList<Devolucao_produto> Devolucao_produtos
		{
			get
			{
				return this._devolucao_produtos;
			}
            set
            {
                this._devolucao_produtos = value;
            }
		}
		
		#region ISerializable Implementation
		
		public Produto()
		{
		}
		
		protected Produto(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			this.Id = info.GetInt32("Id");
			this.Nome = info.GetString("Nome");
			this.Descricao = info.GetString("Descricao");
			this.Preco = info.GetDecimal("Preco");
			this.Imagem = info.GetString("Imagem");
			this.Unidade = (int?)info.GetValue("Unidade", typeof(int?));
			this.Dias_entrega = info.GetInt32("Dias_entrega");
			CustomizeDeserializationProcess(info, context);
		}
		
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			info.AddValue("Id", this.Id, typeof(int));
			info.AddValue("Nome", this.Nome, typeof(string));
			info.AddValue("Descricao", this.Descricao, typeof(string));
			info.AddValue("Preco", this.Preco, typeof(decimal));
			info.AddValue("Imagem", this.Imagem, typeof(string));
			info.AddValue("Unidade", this.Unidade, typeof(int?));
			info.AddValue("Dias_entrega", this.Dias_entrega, typeof(int));
			CustomizeSerializationProcess(info, context);
		}
		
		partial void CustomizeSerializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		partial void CustomizeDeserializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		#endregion
	}
}
#pragma warning restore 1591
