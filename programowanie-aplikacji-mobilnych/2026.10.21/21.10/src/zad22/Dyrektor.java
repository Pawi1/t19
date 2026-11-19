package zad22;

public class Dyrektor {
    public static Komputer zestawBiurowy(){
        return new Komputer.Builder()
                .cpu("Ryzen 3")
                .ram(8)
                .dysk(128,TypDysku.SSD)
                .typObudowy(TypObudowy.BIUROWA)
                .build();
    }
    public static Komputer zestawGamingowy(){
        return new Komputer.Builder()
                .cpu("Ryzen 7")
                .ram(16)
                .gpu("GeForce RTX 3036")
                .zasilacz(800)
                .dysk(1024,TypDysku.NVME)
                .typObudowy(TypObudowy.GAMINGOWA)
                .build();
    }
    public static Komputer zestawSerwerowy(){
        return new Komputer.Builder()
                .cpu("Threadripper")
                .ram(256)
                .zasilacz(800)
                .dysk(16384,TypDysku.HDD) // powinna być lista bo to bezsensu
                .typObudowy(TypObudowy.SERWEROWA)
                .build();
    }
}
