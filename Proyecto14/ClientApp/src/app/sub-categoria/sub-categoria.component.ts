import { Component, OnInit } from '@angular/core';
import { ISubcategoria } from './SubCategoria';
import { SubcategoriaService } from './subcategoria.service';

@Component({
  selector: 'app-sub-categoria',
  templateUrl: './sub-categoria.component.html',
  styleUrls: ['./sub-categoria.component.css']
})
export class SubCategoriaComponent implements OnInit {

  constructor(private SubcategoriaService: SubcategoriaService) { }
  Subcategoria: ISubcategoria[];


  ngOnInit() {

    this.SubcategoriaService.getSubCategoria()
      .subscribe(SubcategoriaDesdeWs => this.Subcategoria = SubcategoriaDesdeWs,
        error => console.error(error));
  }


}
