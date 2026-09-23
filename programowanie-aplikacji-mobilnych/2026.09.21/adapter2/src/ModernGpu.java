public class ModernGpu implements Hdmi, DisplayPort {
    private String bitmap;
    private String sound;

    public void setBitmap(String bitmap) {
        this.bitmap = bitmap;
    }

    public void setSound(String sound) {
        this.sound = sound;
    }

    @Override
    public String getBitmap() {
        return bitmap;
    }

    @Override
    public String getBitmapWithSound() {
        return bitmap+sound;
    }
}
