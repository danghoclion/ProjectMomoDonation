import { Component } from '@angular/core';

@Component({
  selector: 'app-main-question',
  templateUrl: './main-question.component.html',
  styleUrls: ['./main-question.component.css'],
})
export class MainQuestionComponent {
  panelMaxHeight = '500px'; // Adjust this value as needed
  accordionItems = [
    {
      id: 1,
      question: 'Trái Tim MoMo là gì?',
      answer:
        'Trái tim MoMo là tính năng gây quỹ từ thiện của MoMo. Các dự án được đăng tải trong Trái Tim MoMo đều là những dự án đã được lựa chọn cẩn trọng bởi đội ngũ MoMo, và được bảo trợ bởi các tổ chức uy tín.',
      expanded: false,
    },
    {
      id: 2,
      question: 'MoMo có thu lợi nhuận từ việc gây quỹ không?',
      answer:
        'MoMo hoàn toàn không thu lợi nhuận từ việc gây quỹ. Ngoại trừ phí chuyển khoản ngân hàng, 100% số tiền của người dùng được chuyển tới cho các tổ chức bảo trợ.',
      expanded: false,
    },
    {
      id: 3,
      question:
        'Sau bao lâu từ khi quyên góp, tiền sẽ được chuyển đến tay hoàn cảnh?',
      answer:
        'Trong vòng 1 tuấn kể từ khi dự án quyên góp thành công, tiền sẽ được chuyển tới đối tác. Trong những trường hợp khẩn cấp, chúng tôi có thể chuyển sớm hơn.',
      expanded: false,
    },
    {
      id: 4,
      question: 'Ai có thể gây quỹ trên Trái Tim MoMo?',
      answer:
        'Để có thể gây quỹ trên MoMo, hoàn cảnh cần được bảo trợ bởi một tổ chức có pháp nhân là Quỹ, tổ chức phi chính phủ, Doanh nghiệp xã hội hoặc một cơ quan nhà nước có chức năng tiếp nhận tài trợ.',
      expanded: false,
    },
    {
      id: 5,
      question: 'Nếu hoàn cảnh gây quỹ không thành công thì sao?',
      answer:
        'Nhà tài trợ vẫn sẽ chuyển số tiền tương ứng với số Heo Vàng đã quyên góp. Trong một số trường hợp, chúng tôi sẽ kéo dài thêm thời gian gây quỹ',
      expanded: false,
    },
    {
      id: 6,
      question: 'Làm thế nào để liên hệ và gửi hoàn cảnh tới MoMo?',
      answer:
        'Tổ chức đủ điều kiện vui lòng gửi email thông tin của tổ chức tới địa chỉ donation@mservice.com.vn để được nhận hướng dẫn.',
      expanded: false,
    },
  ];

  toggleAccordion(item: any) {
    item.expanded = !item.expanded;
  }
}
