import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  standalone: false,
  styleUrl: './app.component.scss'
})
export class AppComponent {
  predictionForm: FormGroup;
  predictionResult: any = null;
  isLoading = false;
  features = [
    'Accurate product recommendations',
    'Real-time predictions',
    'Powered by advanced ML algorithms',
    'Customizable for your business'
  ];
  testimonials = [
    {
      quote: "This prediction tool increased our conversion rate by 35%!",
      author: "Sarah Johnson, E-commerce Manager"
    },
    {
      quote: "The most accurate product recommendations we've ever used.",
      author: "Michael Chen, Tech Startup Founder"
    }
  ];

  constructor(private fb: FormBuilder) {
    this.predictionForm = this.fb.group({
      productId: ['', Validators.required],
      category: ['', Validators.required],
      priceRange: ['', Validators.required],
      customerSegment: ['', Validators.required]
    });
  }

  onSubmit() {
    if (this.predictionForm.valid) {
      this.isLoading = true;
      // Simulate API call
      setTimeout(() => {
        this.predictionResult = {
          predictedSuccess: 'High',
          confidence: '92%',
          recommendedPrice: `$${(Math.random() * 100 + 50).toFixed(2)}`,
          bestAudience: 'Young professionals (25-34)'
        };
        this.isLoading = false;
      }, 1500);
    }
  }

  scrollToForm() {
    document.getElementById('prediction-form')?.scrollIntoView({ behavior: 'smooth' });
  }
}
