import { Component } from '@angular/core';

@Component({
  selector: 'app-view-item',
  templateUrl: './view-item.component.html',
  styleUrls: ['./view-item.component.css']
})
export class ViewItemComponent {
  empList : Items[] = [];

  constructor(private service : ItemService) {

   

   

  }

  ngOnInit(): void {

    this.service.getAllItems().subscribe((data: Item[])=>{

      this.empList = data

    });

}
}
