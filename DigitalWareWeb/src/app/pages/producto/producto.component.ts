import { Producto } from './../../interface/producto';
import { Component } from '@angular/core';
import { HttpService } from 'src/app/shared/services/http.service';

@Component({
  templateUrl: 'producto.component.html',
  styleUrls: [ './producto.component.scss' ]
})
export class ProductoComponent {

  productos: Producto[];
  msg: string;
  isLoading: boolean;
  constructor(private service: HttpService) {
    this.obtenerProductos();
  }

  obtenerProductos(){
    const model = {
      controlador: 'Producto',
      accion: 'ObtenerProductos',
      parametros: {}
    } as any;

    this.service.post(model).subscribe(
      data => {
        this.productos = data.Producto as Producto[];  // ok
      },
      error => (this.msg = (error as any)), // error
      () => (this.isLoading = false)        // onCompleted
    );
  }

  abrirProducto(e){
    
  }
}
