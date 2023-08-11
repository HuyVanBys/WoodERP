using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace BOSLib
{
    public class BOSDisposeUtility
    {
        static byte[] bigBlock;

        /// <summary>
        /// Allocates 90,000 byte blocks, optionally intersperced with larger blocks
        /// </summary>
        public static string Fill(bool allocateBigBlocks, bool grow, bool alwaysGC, int generation, GCCollectionMode mode)
        {
            string mess = string.Empty;
            // Number of bytes in a small block
            // 90000 bytes, just above the limit for the LOH
            const int blockSize = 90000;

            // Number of bytes in a larger block: 16Mb initially
            int largeBlockSize = 1 << 24;

            // Number of small blocks allocated
            int count = 0;

            try
            {
                // We keep the 'small' blocks around 
                // (imagine an algorithm that allocates memory in chunks)
                List<byte[]> smallBlocks = new List<byte[]>();

                for (; ; )
                {
                    // Write out some status information
                    if ((count % 1000) == 0)
                    {
                        mess = count.ToString();
                    }

                    // Force a GC if necessaryry
                    if (alwaysGC)
                    {
                        if (mode != null)
                            GC.Collect(generation, mode);
                        else
                            GC.Collect();
                    }

                    // Allocate a larger block if we're set up to do soso
                    if (allocateBigBlocks)
                    {
                        bigBlock = new byte[largeBlockSize];
                    }

                    // The next 'large' block will be just slightly largerer
                    if (grow) largeBlockSize++;

                    // Allocate a new block
                    smallBlocks.Add(new byte[blockSize]);
                    count++;
                }
                return mess;
            }
            catch (OutOfMemoryException)
            {
                // Force a GC, which should empty the LOH again
                bigBlock = null;
                if (mode != null)
                    GC.Collect(generation, mode);
                else
                    GC.Collect();

                // Display the results for the amount of memory we managed to allocate
                mess = string.Format("{0}: {1}Mb allocated"
                                  , (allocateBigBlocks ? "With large blocks" : "Only small blocks")
                                  + (alwaysGC ? ", frequent garbage collections" : "")
                                  + (grow ? "" : ", large blocks not growing")
                                  , (count * blockSize) / (1024 * 1024));
                return mess;
            }

        }
        public static void DisposeAll(IEnumerable sequence, int generation, GCCollectionMode mode)
        {
            //if(sequence != null)
            //foreach (object obj in sequence)
            //{
            //    System.IDisposable disposableObject = obj as System.IDisposable;

            //    if (disposableObject != null)
            //    {
            //        disposableObject.Dispose();
            //        disposableObject = null;
            //    }
            //}
            //GC.Collect(generation, mode);
        }
        public static void DisposeDataSet(DataSet sequence, int generation, GCCollectionMode mode)
        {
            //if (sequence != null)
            //    sequence.Dispose();
            //GC.Collect(generation, mode);
        }
    }
}
