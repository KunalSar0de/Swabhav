//service creater command : ng g s service name

import { Injectable } from '@angular/core';
import { Product } from './product';

@Injectable()

export class ProductService {
  products:Array<Product>=new Array<Product>()

  constructor() {
    console.log("Service created...") 
    this.products.push(new Product(101,"book",3.5))
    this.products.push(new Product(102,"pen",4.5))
    this.products.push(new Product(103,"pencil",2))
    this.products.push(new Product(104,"watch",1.5))
    this.products.push(new Product(105,"laptop",5))
  }

  getProducts(){
    return this.products
  }

  getMaxSoldProducts(){
    let index=Math.round(Math.random()*4) 
    return this.products[index]
  }

  addService(product:Product){
  
  }
}
