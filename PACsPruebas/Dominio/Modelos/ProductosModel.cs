using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Contratos;
using DataAccess.Entidades;
using DataAccess.Repositorios;
using Dominio.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos
{
    public class ProductosModel:IDisposable
    {
        private int idPro;
        private string codigo;
        private string nombre;
        private string Descripcion;
        private int idCategoria;
        private int idMarca;
        private decimal precioUnid;
        private int idProvedor;
        private int stock;

        private IProductosRepository productosRepository;
        public EntityState State { private get; set; }
        public int IdPro { get => idPro; set => idPro = value; }
        [Required(ErrorMessage = "El Numero de Serie del Producto es requerido")]
        public string Codigo { get => codigo; set => codigo = value; }
        [Required(ErrorMessage ="El Nombre del Producto es requerido")]
        public string Nombre { get => nombre; set => nombre = value; }
        [Required(ErrorMessage = "La Descripcion del Producto es requerida")]
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        [Required(ErrorMessage = "La Categoria del Producto es requerida")]
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        [Required(ErrorMessage = "La Marca del Producto es requerida")]
        public int IdMarca { get => idMarca; set => idMarca = value; }
        [Required(ErrorMessage = "El Precio del Producto es requerido")]
        public decimal PrecioUnid { get => precioUnid; set => precioUnid = value; }
        [Required(ErrorMessage = "El Provedor del Producto es requerido")]
        public int IdProvedor { get => idProvedor; set => idProvedor = value; }
        [Required(ErrorMessage = "El Stock del Producto es requerido")]
        public int Stock { get => stock; set => stock = value; }

        private List<ProductosModel> listProductos;

        public ProductosModel()
        {
            productosRepository = new ProductosRepository();
        }

        public string SaveCanges()
        {
            string message = null;
            try
            {
                var ProductosDataModel = new Productos();
                ProductosDataModel.idPro = idPro;
                ProductosDataModel.codigo = codigo;
                ProductosDataModel.nombre = nombre;
                ProductosDataModel.Descripcion = Descripcion;
                ProductosDataModel.idCategoria = idCategoria;
                ProductosDataModel.idMarca = idMarca;
                ProductosDataModel.precioUnid = precioUnid;
                ProductosDataModel.idProvedor = idProvedor;
                ProductosDataModel.stock = stock;
                switch (State)
                {
                    case EntityState.Added:
                        productosRepository.Add(ProductosDataModel);
                        message = "Producto agregado correctamente";
                        break;
                    case EntityState.Modifed:
                        productosRepository.Adit(ProductosDataModel);
                        message = "Producto editado correctamente";
                        break;
                    case EntityState.Deleted:
                        productosRepository.Romove(IdPro);
                        message = "Producto eliminado correctamente";
                        break;
                }
            }
            catch(Exception ex)
            {
                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                message = ex.ToString();
            }
            return message;
        }
        public List<ProductosModel> GetAll()
        {
            var productosDataModel = productosRepository.GetAll();
            listProductos = new List<ProductosModel>();
            foreach (Productos item in productosDataModel)
            {
                listProductos.Add(new ProductosModel
                {
                    idPro = item.idPro,
                    codigo = item.codigo,
                    nombre = item.nombre,
                    Descripcion = item.Descripcion,
                    idCategoria = item.idCategoria,
                    idMarca = item.idMarca,
                    precioUnid=item.precioUnid,
                    idProvedor=item.idProvedor,
                    stock=item.stock
                });
            }
            return listProductos;
        }
        public IEnumerable<ProductosModel>FindById(string filter)
        {
            return listProductos.FindAll(p => p.Codigo.Contains(filter) || p.Nombre.Contains(filter));
        }
        public void Dispose()
        {

        }

    }
}
