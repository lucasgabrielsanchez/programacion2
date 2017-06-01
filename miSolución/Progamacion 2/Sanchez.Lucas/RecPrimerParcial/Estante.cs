using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecPrimerParcial
{
    public class Estante
    {
        protected sbyte _capacidad;
        protected List<Producto> _productos;

        private Estante()
        {
            this._productos = new List<Producto>();
        }

        public Estante(sbyte capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public List<Producto> GetProducto()
        {
            return this._productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CAPACIDAD: {0}\n", e._capacidad);

            foreach (Producto item in e._productos)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool aux = false;

            foreach (Producto item in e._productos)
            {
                if (item.Equals(p))
                {
                    if (((Producto)item) == ((Producto)p))
                    {
                        aux = true;
                        break; //para que no siga iterando el foreach
                    }
                }
            }

            return aux;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool aux = false;

            if (e != p)
            {
                if (e._productos.Count() < e._capacidad)
                {
                    e._productos.Add(p);
                    aux = true;
                }
            }

            return aux;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            if (e == p)
            {
                e._productos.Remove(p);
            }

            return e;
        }

        public static Estante operator -(Estante e, Producto.ETipoProducto tipo) 
        {

            //Creo una cola a fin de utilizarla para guardar los objetos que necesito copiar de _productos
            //para luego eliminarlos al finalizar el recorrido del for que identifica los tipos heredados de Producto.
            Queue<Producto> elemList = new Queue<Producto>();

            for (int i = 0; i < e._productos.Count; i++)
            {
                switch (tipo)
                {
                    case Producto.ETipoProducto.Galletita:
                        if (e._productos[i] is Galletita)
                            //e -= e._productos[i];
                            elemList.Enqueue(e._productos[i]);
                        break;
                    case Producto.ETipoProducto.Gaseosa:
                        if (e._productos[i] is Gaseosa)
                            //e -= e._productos[i];
                            elemList.Enqueue(e._productos[i]);
                        break;
                    case Producto.ETipoProducto.Jugo:
                        if (e._productos[i] is Jugo)
                            //e -= e._productos[i];
                            elemList.Enqueue(e._productos[i]);
                        break;
                    case Producto.ETipoProducto.Harina:
                        if (e._productos[i] is Harina)
                            //e -= e._productos[i];
                            elemList.Enqueue(e._productos[i]);
                        break;
                    case Producto.ETipoProducto.Todos:
                        //e -= e._productos[i];
                        elemList.Enqueue(e._productos[i]);
                        break;
                }
            }

            int elemCola = elemList.Count;//guardo la cantidad de elementos de la cola en una variable, porque dentro
                                          //del for de abajo, su respectivo Count va a disminuir en cada Dequeue.
            for (int i = 0; i < elemCola; i++)
            {
                e._productos.Remove(elemList.Dequeue());   
            }
           
            return e;
        }

        public float GetValorEstante(Producto.ETipoProducto tipo)
        {
            float aux = 0;

            foreach (Producto item in this._productos)
            {
                switch (tipo)
                {
                    case Producto.ETipoProducto.Galletita:
                        if (item is Galletita)
                            aux += item.Precio;
                        break;
                    case Producto.ETipoProducto.Gaseosa:
                        if (item is Gaseosa)
                            aux += item.Precio;
                        break;
                    case Producto.ETipoProducto.Jugo:
                        if (item is Jugo)
                            aux += item.Precio;
                        break;
                    case Producto.ETipoProducto.Harina:
                        if (item is Harina)
                            aux += item.Precio;
                        break;
                    case Producto.ETipoProducto.Todos:
                        aux += item.Precio;
                        break;
                }
            }
            return aux;
        }

        float GetValorEstante()
        {
            return this.GetValorEstante(Producto.ETipoProducto.Todos);
        }

        public float ValorEstanteTotal 
        { 
            get {return this.GetValorEstante();} 
        }
        

    }
}
