import { Component, ElementRef, ViewChild } from '@angular/core';
import { VersionService } from '../../services/version.service';
import jsPDF from 'jspdf';

@Component({
  selector: 'app-version-history',
  templateUrl: './version-history.component.html',
  styleUrl: './version-history.component.css',
})
export class VersionHistoryComponent {

  @ViewChild('content', { static: false }) content!: ElementRef;

  makePdf() {
    const pdf = new jsPDF('p', 'pt', 'a2');

    pdf.html(this.content.nativeElement, {
      callback: (pdf) => {
        pdf.save('VersionHistory.pdf');
      },
    });
  }
  
  projects: [] | any;
  constructor(private version: VersionService) {}
  formData: any = {
    version:'',
    type: '',
    change: '',
    changeReason: '',
    createdBy: '',
    revisionDate: '',
    approvalDate: '',
    approvedBy: '',
  };
  ngOnInit(): void {
    this.version.getVersion().subscribe((response: any) => {
      this.projects = response.items;
      console.log(this.projects);
    });
  }

  delete(id: string) {
    this.version.deleteVersion(id).subscribe((response: any) => {
      null;
    });
  }
  onSubmit() {
    console.log('Form submitted:', this.formData);
    this.version
      .createVersion(this.formData)
      .subscribe((response: any) => {
        console.log(response);
      });
  }
}
