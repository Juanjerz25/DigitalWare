import { Factura } from 'src/app/interface/factura';
import { Component, NgModule, Input, Output, EventEmitter, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DxButtonModule } from 'devextreme-angular/ui/button';

import { Router } from '@angular/router';
import { DxDataGridModule, DxFormModule, DxPopupModule, DxSelectBoxModule, DxTemplateModule } from 'devextreme-angular';
import { Cliente } from 'src/app/interface/cliente';
import { HttpService } from '../../services/http.service';
import { FacturaProducto } from 'src/app/interface/factura-producto';
@Component({
  selector: 'app-agregar-factura-producto',
  templateUrl: 'agregar-factura-producto.component.html',
  styleUrls: ['./agregar-factura-producto.component.scss']
})

export class AgregarFacturaProductoComponent implements OnInit {
  FacturaProductos: FacturaProducto[];
  msg: string;
  isLoading: boolean;
  clientes: Cliente[];
  nuevaFactura: boolean;
  selectBoxOptions = {};
  factura = {
    ValorTotal: 0,
    Fecha: new Date()
  } as Factura;

  constructor(private service: HttpService) {
    this.nuevaFactura = true;
    this.obtenerClientes();

  }

  ngOnInit() {

  }


  form_fieldDataChanged(e) {
    this.factura = e.component.option("formData");
    // ...
  }

  obtenerClientes() {
    const model = {
      controlador: 'Cliente',
      accion: 'ObtenerClientes',
      parametros: {}
    } as any;

    this.service.post(model).subscribe(
      data => {
        this.clientes = data.Cliente as Cliente[];  // ok
        this.selectBoxOptions = { dataSource: this.clientes, displayExpr: 'Nombre', valueExpr: 'Id' };
      },
      error => (this.msg = (error as any)), // error
      () => (this.isLoading = false)        // onCompleted
    );
  }
  crearInfoFactura() {

    const model = {
      controlador: 'Factura',
      accion: 'CrearFactura',
      parametros: this.factura

    } as any;

    this.service.post(model).subscribe(
      data => {
        console.log(data)  // ok
        this.nuevaFactura = false;
      },
      error => (this.msg = (error as any)), // error
      () => (this.isLoading = false)        // onCompleted
    );
  }

  obtenerFacturaProductos() {
    const model = {
      controlador: 'Factura',
      accion: 'ObtenerFacturaProductos',
      parametros: {
        Id: this.factura.Id
      }
    } as any;

    this.service.post(model).subscribe(
      data => {
        this.FacturaProductos = data.FacturaProducto as FacturaProducto[];  // ok
      },
      error => (this.msg = (error as any)), // error
      () => (this.isLoading = false)        // onCompleted
    );

  }






}

@NgModule({
  imports: [DxFormModule,
    DxSelectBoxModule,
    DxTemplateModule,
    DxDataGridModule,
    DxButtonModule,
    CommonModule,
    DxPopupModule
  ],
  exports: [AgregarFacturaProductoComponent],
  declarations: [AgregarFacturaProductoComponent],
  providers: [],
})

export class AgregarFacturaProductoModule {
}
