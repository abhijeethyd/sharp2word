namespace Word.W2004.Elements.TableElements
{
    /// <summary>
    /// Concrete strategy 
    /// </summary>
    public class TableHeader : ITableItemStrategy
    {
        public string getBottom()
        {
            return "\n		</w:tr>";
        }

        public string getMiddle()
        {
            string th =
                "\n                {tblHeader} "
                + "\n                <w:tc> "
                + "\n                    <w:tcPr> "
                + "\n                        <w:tcW w:w=\"4258\" w:type=\"dxa\"/> "
                + "\n                        <w:shd w:val=\"clear\" w:color=\"auto\" w:fill=\"E0E0E0\"/> "
                + "\n                    </w:tcPr> "
                + "\n                    <w:p wsp:rsidR=\"00505659\" wsp:rsidRPr=\"004374EC\" wsp:rsidRDefault=\"00505659\"> "
                + "\n                        <w:pPr> "
                + "\n                            <w:rPr> "
                + "\n                                <w:b/> "
                + "\n                            </w:rPr> "
                + "\n                        </w:pPr> "
                + "\n                        <w:r wsp:rsidRPr=\"004374EC\"> "
                + "\n                            <w:rPr> "
                + "\n                                <w:b/> "
                + "\n                            </w:rPr> "
                + "\n                            <w:t>{value}</w:t> "
                + "\n                        </w:r> "
                + "\n                    </w:p> "
                + "\n                </w:tc> "
                ;
            return th;
        }

        public string getTop()
        {
            return "\n		<w:tr wsp:rsidR=\"00505659\" wsp:rsidRPr=\"004374EC\" wsp:rsidTr=\"004374EC\">";
        } 
    }
}