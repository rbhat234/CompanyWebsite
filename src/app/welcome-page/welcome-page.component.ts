import {AfterViewInit, Component, OnInit, ViewChild} from '@angular/core';
import {MatPaginator} from '@angular/material/paginator';
import {MatTableDataSource} from '@angular/material/table';
import{SharedService} from 'src/app/shared.service';

@Component({
  selector: 'app-welcome-page',
  templateUrl: './welcome-page.component.html',
  styleUrls: ['./welcome-page.component.scss']
})
export class WelcomePageComponent implements OnInit {
  
  constructor(private service:SharedService) { }
  ShowListOfUsers:any=[]; //DepartmentList

    ModalTitle:string  | undefined;
    ActivateAddEditComp:boolean=false;
    emp:any;


  ngOnInit(): void {
    this.RefreshListOfUsers();
  }
  RefreshListOfUsers() {
    throw new Error('Method not implemented.');
  }
  addClick(){
    this.emp={
      uid:0,
      UserName:"",
      UserFirstName:"",
      UserLastName:"",
      CompanyName:"",
      email:"",
      paswd:"",
      UserCatalouge:"",
      UserCountry:"",
      UserRole:"",
      UserIsActive:""

    //PhotoFileName:"anonymous.png"  
    }
    this.ModalTitle="Add User";
    this.ActivateAddEditComp=true;
  }

//editClick(item: any){
//  this.emp=item;
//  this.ModalTitle="Edit User Details";
//  this.ActivateAddEditComp=true;
//} 

//deleteClick(item: { uid: any; }){
//      if(confirm('Are You Sure ??  By this You Permantantly Delete This Record')){
//      this.service.deleteUser(item.uid).subscribe(data=>{
//              alert(data.toString());
//              this.RefreshListOfUsers();
//      })
//}

//}

}