import { ServicesService } from './services.service';
import { Component, Injectable, OnInit } from '@angular/core';


@Component({
  selector: 'app-products-list',
  templateUrl: './products-list.component.html',
  styleUrls: ['./products-list.component.scss']
})


export class ProductsListComponent implements OnInit{

  livros: any =[];

  servicesService : ServicesService;

  constructor(servicesService: ServicesService){

    this.servicesService = servicesService;
  }

  ngOnInit(): void {

    this.livros = this.servicesService.getBook().subscribe((
      data) => {
        this.livros = data;
        console.log(this.livros)
      },
      error => {
        console.log(error)
      }

    )
    
  }


}
