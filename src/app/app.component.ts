import { Component, OnInit, Input } from '@angular/core';
import { from } from 'rxjs';
import{SharedService} from 'src/app/shared.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})



export class AppComponent implements OnInit {
  title = 'Company-Website';

  constructor(private service:SharedService) { }

  @Input() emp:any;
    uid:string | undefined;
    UserName:string | undefined;
    UserFirstName:string | undefined;
    UserLastName:string | undefined;
    CompanyName:string | undefined;
    email:string | undefined;
    paswd:string | undefined;
    UserCatalouge:string | undefined;
    UserCountry:string | undefined;
    UserRole:string | undefined;
    UserIsActive:string | undefined;

  ngOnInit(): void {
      //this.uid=this.emp.uid;
      this.UserName=this.emp.UserName;
      this.UserFirstName=this.emp.UserFirstName;
      this.UserLastName=this.emp.UserLastName;
      this.CompanyName=this.emp.CompanyName;
      this.email=this.emp.email;
      this.paswd=this.emp.paswd;
      this.UserCatalouge=this.emp.UserCatalouge;
      this.UserCountry=this.emp.UserCountry;
      this.UserRole=this.emp.UserRole;
      this.UserIsActive=this.emp.UserIsActive;
    }

  RegEmp(){
      var val={
      //uid:this.uid,
      UserName:this.UserName,
      UserFirstName:this.UserFirstName,
      UserLastName:this.UserLastName,
      CompanyName:this.CompanyName,
      email:this.email,
      paswd:this.paswd,
      UserCatalouge:this.UserCatalouge,
      UserCountry:this.UserCountry,
      UserRole:this.UserRole,
      UserIsActive:this.UserIsActive
            //  PhotoFileName:this.PhotoFileName
              };
      this.service.addUser(val).subscribe(res=>
            {   
                alert(res.toString());
            }
            );        
    }

    siginUser(){
      var val={
                email:this.email,
                paswd:this.paswd   
              };
      this.service.siginUser(val).subscribe(res=>
        {
          alert(res.toString());
        });
          
    }

  //edit start  
  
//  options: FormGroup;
//  hideRequiredControl = new FormControl(false);
//  floatLabelControl = new FormControl('auto');
//
//  constructor(fb: FormBuilder) {
//    this.options = fb.group({
//      hideRequired: this.hideRequiredControl,
//      floatLabel: this.floatLabelControl,
//    });
//  }

//edit end


}

