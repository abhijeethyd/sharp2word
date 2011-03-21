using NUnit.Framework;
using Word.Utils;
using Word.W2004;
using Word.W2004.Elements;

namespace Test.W2004
{
    public class Header2004Test : Assert
    {
        [Test]
        public void sanityTest()
        {
            Header2004 hd = new Header2004();
            Assert.AreEqual("", hd.getContent());
        }

        [Test]
        public void testAddEle()
        {
            Header2004 hd = new Header2004();
            hd.addEle(new Paragraph("p1"));
            Assert.AreEqual(2, TestUtils.regexCount(hd.getContent(), "<*w:hdr"));
            Assert.AreEqual(1, TestUtils.regexCount(hd.getContent(), "<w:t>p1</w:t>"));
        }

        [Test]
        public void testAddEleString()
        {
            Header2004 hd = new Header2004();
            hd.addEle("<w:t>p1</w:t>");
            Assert.AreEqual(2, TestUtils.regexCount(hd.getContent(), "<*w:hdr"));
            Assert.AreEqual(1, TestUtils.regexCount(hd.getContent(), "<w:t>p1</w:t>"));
        }

        [Test]
        public void testHideHeaderandFooter()
        { //this has to be tested in the body...
            Header2004 hd = new Header2004();
            hd.setHideHeaderAndFooterFirstPage(true);
            Assert.True(hd.getHideHeaderAndFooterFirstPage());
        }

    }
}