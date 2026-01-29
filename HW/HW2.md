# HW2: Code Smell – Speculative Generality

## a) ความหมายของ Speculative Generality

Speculative Generality คือ code smell ที่เกิดจากการออกแบบโค้ดให้มีความเป็น “ทั่วไป” หรือเผื่อการใช้งานในอนาคตมากเกินไป ทั้งที่ในปัจจุบันยังไม่มี requirement ที่ต้องใช้งานจริง  

โดยมักจะพบในลักษณะ เช่น  
- สร้าง class, interface หรือ method เผื่อไว้ก่อน  
- เพิ่ม abstraction หรือ parameter ที่ยังไม่ได้ใช้งาน  
- ออกแบบโครงสร้างซับซ้อนเกินความจำเป็น  

ผลที่ตามมาคือโค้ดจะอ่านยาก ดูแลรักษายาก และทำให้ผู้พัฒนาคนอื่นสับสน ทั้งที่ฟังก์ชันการทำงานจริงไม่ได้ซับซ้อนขนาดนั้น ซึ่งขัดกับหลักการ YAGNI (You Aren’t Gonna Need It)

---

## b) ตัวอย่างโค้ดที่เกิด Speculative Generality

ตัวอย่างด้านล่างเป็นระบบชำระเงินที่ออกแบบเผื่อว่าจะมีหลายรูปแบบในอนาคต แต่ในความเป็นจริงปัจจุบันรองรับแค่การจ่ายด้วยบัตรเครดิตเท่านั้น

```java
interface PaymentProcessor {
    void process(double amount);
}

class CreditCardPayment implements PaymentProcessor {
    public void process(double amount) {
        System.out.println("Paying " + amount + " by credit card");
    }
}

class PaymentService {
    private PaymentProcessor processor;

    public PaymentService(PaymentProcessor processor) {
        this.processor = processor;
    }

    public void pay(double amount) {
        processor.process(amount);
    }
}
