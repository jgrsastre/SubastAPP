using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLayer.Models
{
    public class E_AuctionServer
    {
        private int _subasta_id;

        public int subasta_id
        {
            get { return _subasta_id; }
            set { _subasta_id = value; }
        }


        private int _usuario_id;

        public int usuario_id
        {
            get { return _usuario_id; }
            set { _usuario_id = value; }
        }

        private string _nombre_categoria;

        public string nombre_categoria
        {
            get { return _nombre_categoria; }
            set { _nombre_categoria = value; }
        }

        private string _titulo;

        public string titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        private string _descripcion;

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private DateTime _fecha_inicio;

        public DateTime fecha_inicio
        {
            get { return _fecha_inicio; }
            set { _fecha_inicio = value; }
        }

        private DateTime _fecha_fin;

        public DateTime fecha_fin
        {
            get { return _fecha_fin; }
            set { _fecha_fin = value; }
        }

        private decimal _precio_inicial;

        public decimal precio_inicial
        {
            get { return _precio_inicial; }
            set { _precio_inicial = value; }
        }

        private decimal _precio_venta;

        public decimal precio_venta
        {
            get { return _precio_venta; }
            set { _precio_venta = value; }
        }

        private string _ImagenBase64;

        public string ImagenBase64
        {
            get { return _ImagenBase64; }
            set { _ImagenBase64 = value; }
        }
    }
}
