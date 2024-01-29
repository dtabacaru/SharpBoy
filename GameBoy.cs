static class GameBoy {
    public static void PowerOn(string rom_path) {
        Cpu.SetRom(File.ReadAllBytes(rom_path));
        Cpu.Run();
    }
}