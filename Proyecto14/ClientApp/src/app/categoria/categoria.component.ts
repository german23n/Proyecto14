import { Component, OnInit } from '@angular/core';
import { Icategoria } from './Categoria';
import { CategoriaService } from './categoria.service';

@Component({
  selector: 'app-categoria',
  templateUrl: './categoria.component.html',
  styleUrls: ['./categoria.component.css']
})
export class CategoriaComponent implements OnInit {

  constructor(private CategoriaService : CategoriaService) { }
  categoria : Icategoria[];


  ngOnInit() {

    this.CategoriaService.getCategoria()
      .subscribe(categoriaDesdeWs => this.categoria = categoriaDesdeWs,
      error => console.error(error));
  }


 

}

