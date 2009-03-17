
//
// BtsErrorLookup.cs
//
// Author:
//    Tomas Restrepo (tomas@winterdom.com)
//

using System;
using System.Collections.Generic;
using System.Globalization;

namespace Winterdom.BizTalk.Utilities
{
   class BtsError
   {
      private string _source;
      private string _name;
      private uint _hresult;

      public string Source
      {
         get { return _source; }
      }
      public string Name
      {
         get { return _name; }
      }
      public uint HResult
      {
         get { return _hresult; }
      }

      public BtsError(uint hresult, string name, string source)
      {
         _hresult = hresult;
         _name = name;
         _source = source;
      }

      public override string ToString()
      {
         return string.Format("0x{0:x8}: {1} ({2})", HResult, Name, Source);
      }
   } // class BtsError

   static class BtsErrorLookup
   {
      private static List<BtsError> _errorMap;
      const string XMLASM = "Xml Assembler Component";
      const string XMLDASM = "Xml Disassembler Component";
      const string XMLVAL = "Xml Validator Component";
      const string FFASM = "Flat File Assembler Component";
      const string FFDASM = "Flat File Disassembler Component";
      const string BTFDASM = "BTF Disassembler Component";
      const string BTFASM = "BTF Assembler Component";
      const string GENCOM = "General Pipeline Component";
      const string TPPROX = "Transport Proxy";

      static BtsErrorLookup()
      {
         _errorMap = new List<BtsError>();
#region XMLVAL
         AddEntry(0xc0c0146b, "BTS_E_DUPLICATE_NAMESPACE", XMLVAL);
         AddEntry(0xc0c02102, "BTS_E_XML_VALIDATOR_CANNOT_GET_DOCSPEC_BY_NAME", XMLVAL);
         AddEntry(0xc0c02101, "BTS_E_XML_VALIDATOR_CANNOT_GET_DOCSPEC_BY_TYPE", XMLVAL);
         AddEntry(0xc0c02100, "BTS_E_XML_VALIDATOR_FAILED", XMLVAL);
         AddEntry(0xc0c02103, "BTS_E_XML_VALIDATOR_FAILED_TO_VALIDATE_NOSCHEMA", XMLVAL);
#endregion // XMLVAL

#region XMLDASM
         AddEntry(0xc0c01467, "BtsErrorDisassemblerCannotCreateProcessor", XMLDASM);
         AddEntry(0xc0c01463, "BtsErrorDisassemblerCannotGetDocspecByName", XMLDASM);
         AddEntry(0xc0c01462, "BtsErrorDisassemblerCannotGetDocspecByType", XMLDASM);
         AddEntry(0xc0c01470, "BtsErrorDisassemblerDoctypeDoesntMatchSchemas", XMLDASM);
         AddEntry(0xc0c0146b, "BtsErrorDisassemblerDuplicateNamespace", XMLDASM);
         AddEntry(0xc0c01471, "BtsErrorDisassemblerFailedToValidate", XMLDASM);
         AddEntry(0xc0c01472, "BtsErrorDisassemblerFailedToValidateNoSchema", XMLDASM);
         AddEntry(0xc0c01484, "BtsErrorDisassemblerInvalidEnvelopeStructure", XMLDASM);
         AddEntry(0xc0c01466, "BtsErrorDisassemblerMissingDocspecName", XMLDASM);
         AddEntry(0xc0c01461, "BtsErrorDisassemblerNoBody", XMLDASM);
         AddEntry(0xc0c01435, "BtsErrorDisassemblerNoData", XMLDASM);
         AddEntry(0xc0c01465, "BtsErrorDisassemblerNullBody", XMLDASM);
         AddEntry(0xc0c01486, "BtsErrorDisassemblerSuspendingMessage", XMLDASM);
         AddEntry(0xc0c01468, "BtsErrorDisassemblerUnexpectedBehavior", XMLDASM);
         AddEntry(0xc0c01469, "BtsErrorDisassemblerUnexpectedEvent", XMLDASM);
         AddEntry(0xc0c01464, "BtsErrorDisassemblerUnrecognizedDataInStream", XMLDASM);
         AddEntry(0xc0c0146a, "BtsErrorDisassemblerXmlNotWellformed", XMLDASM);
#endregion // XMLDASM

#region XMLASM
         AddEntry(0xc0c0183a, "BtsErrorAssemblerAsemblingMultipleDocumentsWithoutAnEnvelope", XMLASM);
         AddEntry(0xc0c01828, "BtsErrorAssemblerCannotFindMatchingDocspec", XMLASM);
         AddEntry(0xc0c01827, "BtsErrorAssemblerCannotGetDocspecByName", XMLASM);
         AddEntry(0xc0c01826, "BtsErrorAssemblerCannotGetDocspecByType", XMLASM);
         AddEntry(0xc0c01829, "BtsErrorAssemblerDoctypeDoesntMatchSchemas", XMLASM);
         AddEntry(0xc0c0146b, "BtsErrorAssemblerDuplicateNamespace", XMLASM);
         AddEntry(0xc0c01830, "BtsErrorAssemblerFailedToValidate", XMLASM);
         AddEntry(0xc0c01831, "BtsErrorAssemblerFailedToValidateNoSchema", XMLASM);
         AddEntry(0xc0c0182c, "BtsErrorAssemblerInvalidDateTimeCast", XMLASM);
         AddEntry(0xc0c01832, "BtsErrorAssemblerMultiplePartsOnMultipleMessages", XMLASM);
#endregion // XMLASM

#region FFDASM
         AddEntry(0xc0c01463, "BtsErrorDisassemblerCannotLoadDocspecByName", FFDASM);
         AddEntry(0xc0c01462, "BtsErrorDisassemblerCannotLoadDocspecByType", FFDASM);
         AddEntry(0xc0c01466, "BtsErrorDisassemblerMissingDocspecName", FFDASM);
         AddEntry(0xc0c01435, "BtsErrorDisassemblerNoDataFound", FFDASM);
         AddEntry(0xc0c01465, "BtsErrorDisassemblerNullBodyEncountered", FFDASM);
         AddEntry(0xc0c01487, "BtsErrorDisassemblerRecoverableInterchangesRequireTags", FFDASM);
         AddEntry(0xc0c01488, "BtsErrorDisassemblerRecoverableInterchangesRequireTagsToBeUnique", FFDASM);
         AddEntry(0xc0c01486, "BtsErrorDisassemblerSuspendingMessage", FFDASM);
         AddEntry(0xc0c01489, "BtsErrorDisassemblerTrailerSpecifiedAndNotProcessed", FFDASM);
         AddEntry(0xc0c01464, "BtsErrorDisassemblerUnrecognizedDataInStream", FFDASM);
         AddEntry(0xc0c0148b, "BtsErrorRecoverableInterchangesATrailerCannotBeUsedIfDocumentSpecDoesntHaveTagAtRoot", FFDASM);
         AddEntry(0xc0c0148a, "BtsErrorRecoverableInterchangesRequireTagsForTrailerSpec", FFDASM);
#endregion // FFDASM

#region FFASM
         AddEntry(0xc0c01828, "BtsErrorAssemblerCannotFindMatchingDocspec", FFASM);
         AddEntry(0xc0c01827, "BtsErrorAssemblerCannotGetDocspecByName", FFASM);
         AddEntry(0xc0c01826, "BtsErrorAssemblerCannotGetDocspecByType", FFASM);
         AddEntry(0xc0c0182b, "BtsErrorAssemblerHeaderSpecNameNotSpecified", FFASM);
         AddEntry(0xc0c01435, "BtsErrorAssemblerNoData", FFASM);
         AddEntry(0xc0c01465, "BtsErrorAssemblerNullBodyEncountered", FFASM);
         AddEntry(0xc0c0182a, "BtsErrorAssemblerUnableToLoadDocspec", FFASM);
#endregion // FFASM

#region BTFDASM
         AddEntry(0xc0c01837, "BTS_E_BTF_INVALID_DATE_FORMAT_EXPIRESAT", BTFDASM);
         AddEntry(0xc0c01838, "BTS_E_BTF_INVALID_DATE_FORMAT_SENDBY", BTFDASM);
         AddEntry(0xc0c01485, "BTS_E_BTF_TIME_STAMP_EXPIRED", BTFDASM);
         AddEntry(0xc0c01463, "BTS_E_DISASSEMBLER_CANNOT_GET_DOCSPEC_BY_NAME", BTFDASM);
         AddEntry(0xc0c01462, "BTS_E_DISASSEMBLER_CANNOT_GET_DOCSPEC_BY_TYPE", BTFDASM);
         AddEntry(0xc0c01483, "BTS_E_LOAD_MESSAGE_STATE", BTFDASM);
         AddEntry(0xc0c01462, "BTS_E_DISASSEMBLER_CANNOT_GET_DOCSPEC_BY_TYPE", BTFDASM);
         AddEntry(0xc0c01483, "BTS_E_INNER_EXCEPTION", BTFDASM);
         AddEntry(0xc0c01481, "BTS_E_LOAD_MESSAGE_STATE", BTFDASM);
         AddEntry(0xc0c01482, "BTS_E_NEXT_MESSAGE_STATE", BTFDASM);
         AddEntry(0xc0c01479, "BTS_E_NULL_MESSAGE", BTFDASM);
         AddEntry(0xc0c01478, "BTS_E_NULL_PIPELINE_CONTEXT", BTFDASM);
         AddEntry(0xc0c01480, "BTS_E_NULL_PROPERTY_BAG", BTFDASM);
         AddEntry(0xc0c01477, "BTS_E_UNKNOWN", BTFDASM);
#endregion // BTFDASM

#region BTFASM
         AddEntry(0xc0c01833, "BTS_E_BTFASSEMBLER_MESSAGE_EXPIRED", BTFASM);
         AddEntry(0xc0c01836, "BTS_E_BTFASSEMBLER_MESSAGE_MISSING_OPTIONAL_CONTEXT", BTFASM);
         AddEntry(0xc0c01834, "BTS_E_BTFASSEMBLER_MESSAGE_MISSING_REQUIRED_CONTEXT", BTFASM);
         AddEntry(0xc0c01835, "BTS_E_BTFASSEMBLER_MESSAGE_MULTIPLE_MSG_ADDED", BTFASM);
         AddEntry(0xc0c01839, "BTS_E_BTFASSEMBLER_MESSAGE_RETRY_EXHAUSTED", BTFASM);
#endregion // BTFASM

#region GENCOMP
         AddEntry(0xc0c01437, "BTS_E_DISASSEMBLER_ENV_XPATH_ERROR", GENCOM);
         AddEntry(0xc0c01208, "BTS_E_GENERIC_EXCEPTION", GENCOM);
         AddEntry(0xc0c01473, "BTS_E_INVALID_CONVERSION", GENCOM);
         AddEntry(0xc0c01476, "BTS_E_NULL_XPATH", GENCOM);
         AddEntry(0xc0c01474, "BTS_E_TYPE_NOT_SUPPORTED", GENCOM);
         AddEntry(0xc0c01475, "BTS_E_UNEXPECTED_XPATH", GENCOM);
#endregion // GENCOMP

#region TPPROX
         AddEntry(0xC0C0165C, "BTS_E_EPM_DROPPING_MSG_ON_AUTH_FAILURE", TPPROX);
         AddEntry(0xC0C01662, "BTS_E_EPM_NULL_CORRELATION_TOKEN", TPPROX);
         AddEntry(0xC0C0163C, "BTS_E_MESSAGING_SHUTTING_DOWN", TPPROX);
         AddEntry(0xC0C0162E, "BTS_E_NO_BACKUP_TRANSPORT", TPPROX);
         AddEntry(0xc00001, "BTS_S_EPM_MESSAGE_SUSPENDED", TPPROX);
         AddEntry(0xc0165e, "BTS_S_EPM_SECURITY_CHECK_FAILED", TPPROX);
         AddEntry(0xC0C01680, "E_BTS_NO_SUBSCRIPTION", TPPROX);
         AddEntry(0xC0C01623, "E_BTS_PERSISTENCE_FAILURE", TPPROX);
         AddEntry(0xC0C01627, "E_BTS_SUBMIT_FAILED", TPPROX);
         AddEntry(0xC0C0164B, "E_BTS_URL_DISALLOWED", TPPROX);
#endregion // TPPROX
      }

      private static void AddEntry(uint hresult, string name, string component)
      {
         _errorMap.Add(new BtsError(hresult, name, component));
      }

      public static IList<BtsError> Lookup(uint hresult)
      {
         List<BtsError> found = new List<BtsError>();
         foreach ( BtsError error in _errorMap )
         {
            if ( error.HResult == hresult )
               found.Add(error);
         }
         return found;
      }
   } // class BtsErrorLookup

   static class BtsErrorLookupApp
   {
      public static void Main(string[] args)
      {
         if ( args.Length != 1 )
         {
            Console.WriteLine("Usage: BtsErrorLookup <hresult>");
            return;
         }
         string code = args[0];
         if ( code.StartsWith("0x") || code.StartsWith("0X") )
            code = code.Substring(2);
         uint hresult;
         if ( UInt32.TryParse(code, NumberStyles.HexNumber, null, out hresult) )
         {
            foreach ( BtsError error in BtsErrorLookup.Lookup(hresult) )
            {
               Console.WriteLine(error);
            }
         } else
         {
            Console.WriteLine("Invalid hresult");
         }
      }
   } // class BtsErrorLookupApp

} // namespace Winterdom.BizTalk.Utilities