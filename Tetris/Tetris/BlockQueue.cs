using System;

namespace Tetris
{
    public class BlockQueue
    {
        private readonly Block[] blocks = new Block[]
        {
            new IBlock(),
            new JBlock(),
            new LBlock(),
            new OBlock(),
            new SBlock(),
            new TBlock(),
            new ZBlock(),
        };

        private readonly Random random = new Random();
        public Block NextBlock { get; private set; }

        public BlockQueue()
        {
            NextBlock = GetRandomBlock();
        }

        private Block GetRandomBlock()
        {
            return blocks[random.Next(blocks.Length)];
        }

        public Block GetAndUpdateNextBlock()
        {
            Block currentBlock = NextBlock;
            do
            {
                NextBlock = GetRandomBlock();
            } while (Block.Id == NextBlock.Id);  // Ensure no consecutive duplicates

            return currentBlock;
        }
    }
}
