public class MyThread2 implements Runnable{
    @Override
    public void run() {
        for (int i = 11; i < 21; i++) {
            System.out.println(Thread.currentThread().getName() +" "+ i);
        }
    }
}
