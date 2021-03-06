﻿namespace Contpaqi.SistemasComerciales.Sdk.Extras.Modelos
{
    public class DireccionComercial
    {
        public DireccionComercial()
        {
            ClienteProveedor = new ClienteProveedorComercial();
        }

        public string CodCteProv { get; set; }

        public int TipoCatalogo { get; set; }

        public int TipoDireccion { get; set; }

        public string NombreCalle { get; set; }

        public string NumeroExterior { get; set; }

        public string NumeroInterior { get; set; }

        public string Colonia { get; set; }

        public string CodigoPostal { get; set; }

        public string Telefono1 { get; set; }

        public string Telefono2 { get; set; }

        public string Telefono3 { get; set; }

        public string Telefono4 { get; set; }

        public string Email { get; set; }

        public string DireccionWeb { get; set; }

        public string Ciudad { get; set; }

        public string Estado { get; set; }

        public string Pais { get; set; }

        public string TextoExtra { get; set; }

        // Propiedades Extras
        public int IdDireccion { get; set; }

        public int IdCatalogo { get; set; }

        public ClienteProveedorComercial ClienteProveedor { get; set; }
    }
}