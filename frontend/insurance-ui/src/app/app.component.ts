import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { PremiumService } from './services/premium.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {

  constructor(private fb: FormBuilder, private svc: PremiumService) {}

  occupations = ["Cleaner", "Doctor", "Author", "Farmer", "Mechanic", "Florist", "Other"];

  form: any;
  result: any = null;

  ngOnInit() {
    this.form = this.fb.group({
      name: ['', Validators.required],
      ageNextBirthday: [null, Validators.required],
      deathCover: [null, Validators.required],
      occupationName: ['', Validators.required],
      deathSumInsured: [null, Validators.required]
    });
  }

  calculate() {
    if (!this.form.valid) {
      alert("Please fill all required fields!");
      return;
    }

    this.svc.calculatePremium(this.form.value).subscribe({
      next: (res) => this.result = res,
      error: (err) => console.error(err)
    });
  }
}
