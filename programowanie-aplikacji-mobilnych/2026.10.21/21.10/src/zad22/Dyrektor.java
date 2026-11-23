package zad22;

public class Dyrektor {
    public static Komputer zestawBiurowy(){
        return new Komputer.Builder()
                .procesor("Ryzen 3")
                .ram(8)
                .dysk(128,TypDysku.SSD)
                .typObudowy(TypObudowy.BIUROWA)
                .build();
    }
    public static Komputer zestawGamingowy(){
        return new Komputer.Builder()
                .procesor("Ryzen 7")
                .ram(16)
                .kartaGraficzna("GeForce RTX 3036")
                .zasilacz(800)
                .dysk(1024,TypDysku.NVME)
                .typObudowy(TypObudowy.GAMINGOWA)
                .build();
    }
    public static Komputer zestawSerwerowy(){
        return new Komputer.Builder()
                .procesor("Threadripper")
                .ram(256)
                .dysk(16384,TypDysku.HDD) // powinna być lista bo to bezsensu
                .typObudowy(TypObudowy.SERWEROWA)
                .build();
    }
}
