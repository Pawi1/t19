public class Main {
    static void main() {
        var t1 = new Thread(new MyThread());
        t1.setPriority(1);
        var t2 = new Thread(new MyThread2());
        t2.setPriority(10);

    t1.start();
    t2.start();
    }
}
