import { Component } from '@angular/core';
import { DataService } from '../data.service';
import {Data} from '../data';
import { CartService } from '../cart.service';
@Component({
  selector: 'app-viewitems',
  templateUrl: './viewitems.component.html',
  styleUrls: ['./viewitems.component.css']
})
export class ViewitemsComponent {
  item: Data[] = [];

  isAdmin:Boolean=false;

  constructor(private dataService: DataService,private cs : CartService) { }
  deletePost(id:number){
    this.dataService.delete(id).subscribe(res => {
         this.item = this.item.filter(item=> item.itemId !== id);
         console.log('User deleted successfully!');
    })
  
  }
  addtocart(item:any){
    this.cs.addtoCart(item);

  }
  ngOnInit() {

    this.dataService.sendGetRequest().subscribe((data: any)=>{
      console.log(data);
      this.item = data;
    }) 

}
}
