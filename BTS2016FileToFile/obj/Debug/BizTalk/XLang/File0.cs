
#pragma warning disable 162

namespace BTS2016FileToFile
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_In",
        new System.Type[]{
            typeof(BTS2016FileToFile.__messagetype_BTS2016FileToFile_Book)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_BookFileIn : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_BookFileIn(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_BookFileIn(PortType_BookFileIn p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_BookFileIn p = new PortType_BookFileIn(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_In = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_In",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_BookFileIn),
            typeof(__messagetype_BTS2016FileToFile_Book),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_In" ] = Operation_In;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_Out",
        new System.Type[]{
            typeof(BTS2016FileToFile.__messagetype_BTS2016FileToFile_DiscountedBook)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_DiscountedBookFile : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_DiscountedBookFile(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_DiscountedBookFile(PortType_DiscountedBookFile p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_DiscountedBookFile p = new PortType_DiscountedBookFile(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_Out = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_Out",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_DiscountedBookFile),
            typeof(__messagetype_BTS2016FileToFile_DiscountedBook),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_Out" ] = Operation_Out;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 172 "C:\workspace\development\BTS2016FileToFile\BTS2016FileToFile\FileToFile.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Port_BookFileIn", "Operation_In", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(BTS2016FileToFile.PortType_BookFileIn),
            typeof(BTS2016FileToFile.PortType_DiscountedBookFile)
        },
        new System.String[] {
            "Port_BookFileIn",
            "Port_DiscountedBookFile"
        },
        new System.Type[] {
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class FileToFile : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(FileToFile));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static FileToFile()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __FileToFile_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public FileToFile(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "FileToFile", tracker)
        {
            ConstructorHelper();
        }

        public FileToFile(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "FileToFile")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>45ff6557-52a7-4b70-a660-386a0771f67f</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>b6f81957-ad24-4312-98c2-27fb921e08ed</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_MsgIn</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>26e96ab9-4c51-43d0-bc3d-bf5fa00c68cf</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstMsg_DiscountedPriceMsg</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>da0ae9de-08ab-4cf0-b0e1-bbbe011fb041</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Trans_BookToDiscountedBook</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>2a18d8ce-ed90-41a8-b1a1-7830c85b34f3</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>6d586135-6bfc-4b7b-b1cf-4178b052863c</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>272bb1a3-c952-4815-8acc-3021bd512ddb</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>c96e6573-867d-445c-ab4d-3493ceb59c0b</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_MsgOut</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'FileToFile'</ActionName><IsAtomic>0</IsAtomic><Line>172</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>183</Line><Position>22</Position><ShapeID>'b6f81957-ad24-4312-98c2-27fb921e08ed'</ShapeID>
<Messages>
	<MsgInfo><name>MsgBook</name><part>part</part><schema>BTS2016FileToFile.Book</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>185</Line><Position>13</Position><ShapeID>'26e96ab9-4c51-43d0-bc3d-bf5fa00c68cf'</ShapeID>
<Messages>
	<MsgInfo><name>MsgDiscountedBook</name><part>part</part><schema>BTS2016FileToFile.DiscountedBook</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>MsgBook</name><part>part</part><schema>BTS2016FileToFile.Book</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>191</Line><Position>13</Position><ShapeID>'c96e6573-867d-445c-ab4d-3493ceb59c0b'</ShapeID>
<Messages>
	<MsgInfo><name>MsgDiscountedBook</name><part>part</part><schema>BTS2016FileToFile.DiscountedBook</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='7617eb11-288a-49b6-8fef-d5ed3a71ede8' LowerBound='1.1' HigherBound='42.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='BTS2016FileToFile' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='1c41e293-ece8-4356-a578-72b39fc0cf8e' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_BookFileIn' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='00571557-e906-4007-bd32-4b8ea7aeeb86' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_In' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='6809bec0-b587-47c9-9f7a-a96efe517886' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.17'>
                    <om:Property Name='Ref' Value='BTS2016FileToFile.Book' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='03990e18-b51a-4c70-b9b0-765b1230ab7b' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_DiscountedBookFile' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='db9e3bb7-b541-4501-ae50-27550497e93d' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_Out' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='4ec3e386-567a-4a1e-a235-64165e88266d' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.27'>
                    <om:Property Name='Ref' Value='BTS2016FileToFile.DiscountedBook' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='9c544425-803e-466e-a504-ed7a453a08ee' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='41.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='FileToFile' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='45ff6557-52a7-4b70-a660-386a0771f67f' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='b6f81957-ad24-4312-98c2-27fb921e08ed' ParentLink='ServiceBody_Statement' LowerBound='29.1' HigherBound='31.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Port_BookFileIn' />
                    <om:Property Name='MessageName' Value='MsgBook' />
                    <om:Property Name='OperationName' Value='Operation_In' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_MsgIn' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='26e96ab9-4c51-43d0-bc3d-bf5fa00c68cf' ParentLink='ServiceBody_Statement' LowerBound='31.1' HigherBound='37.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstMsg_DiscountedPriceMsg' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='da0ae9de-08ab-4cf0-b0e1-bbbe011fb041' ParentLink='ComplexStatement_Statement' LowerBound='34.1' HigherBound='36.1'>
                        <om:Property Name='ClassName' Value='BTS2016FileToFile.BookToDiscountedBook' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Trans_BookToDiscountedBook' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='MessagePartRef' OID='2a18d8ce-ed90-41a8-b1a1-7830c85b34f3' ParentLink='Transform_InputMessagePartRef' LowerBound='35.89' HigherBound='35.96'>
                            <om:Property Name='MessageRef' Value='MsgBook' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='6d586135-6bfc-4b7b-b1cf-4178b052863c' ParentLink='Transform_OutputMessagePartRef' LowerBound='35.28' HigherBound='35.45'>
                            <om:Property Name='MessageRef' Value='MsgDiscountedBook' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='272bb1a3-c952-4815-8acc-3021bd512ddb' ParentLink='Construct_MessageRef' LowerBound='32.23' HigherBound='32.40'>
                        <om:Property Name='Ref' Value='MsgDiscountedBook' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='c96e6573-867d-445c-ab4d-3493ceb59c0b' ParentLink='ServiceBody_Statement' LowerBound='37.1' HigherBound='39.1'>
                    <om:Property Name='PortName' Value='Port_DiscountedBookFile' />
                    <om:Property Name='MessageName' Value='MsgDiscountedBook' />
                    <om:Property Name='OperationName' Value='Operation_Out' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_MsgOut' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='bf68b588-2f61-42af-8144-1c7dcd2ffe2c' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BTS2016FileToFile.PortType_BookFileIn' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_BookFileIn' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='04543627-5380-4748-a12a-2e580511b02d' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='54439ff6-81e1-4e84-99ea-ca412a47e2cd' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BTS2016FileToFile.PortType_DiscountedBookFile' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_DiscountedBookFile' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='d19b6ab3-d56e-49fb-8671-96b0ec888855' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='85bc8051-6c3c-4789-86e5-ca8bba67defe' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='BTS2016FileToFile.Book' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MsgBook' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='85031341-5491-48b0-bc6b-01782f545fe3' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='BTS2016FileToFile.DiscountedBook' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MsgDiscountedBook' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __FileToFile_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __FileToFile_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "FileToFile")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                FileToFile __svc__ = (FileToFile)_service;
                __FileToFile_root_0 __ctx0__ = (__FileToFile_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Port_BookFileIn != null)
                {
                    __svc__.Port_BookFileIn.Close(this, null);
                    __svc__.Port_BookFileIn = null;
                }
                if (__svc__.Port_DiscountedBookFile != null)
                {
                    __svc__.Port_DiscountedBookFile.Close(this, null);
                    __svc__.Port_DiscountedBookFile = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __FileToFile_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __FileToFile_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "FileToFile")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                FileToFile __svc__ = (FileToFile)_service;
                __FileToFile_1 __ctx1__ = (__FileToFile_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__MsgBook != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MsgBook);
                    __ctx1__.__MsgBook = null;
                }
                if (__ctx1__ != null && __ctx1__.__MsgDiscountedBook != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MsgDiscountedBook);
                    __ctx1__.__MsgDiscountedBook = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("MsgBook")]
            public __messagetype_BTS2016FileToFile_Book __MsgBook;
            [Microsoft.XLANGs.Core.UserVariableAttribute("MsgDiscountedBook")]
            public __messagetype_BTS2016FileToFile_DiscountedBook __MsgDiscountedBook;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_BookFileIn")]
        internal PortType_BookFileIn Port_BookFileIn;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_DiscountedBookFile")]
        internal PortType_DiscountedBookFile Port_DiscountedBookFile;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_BookFileIn.Operation_In},
                                               typeof(FileToFile).GetField("Port_BookFileIn", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(FileToFile), "Port_BookFileIn"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_DiscountedBookFile.Operation_Out},
                                               typeof(FileToFile).GetField("Port_DiscountedBookFile", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(FileToFile), "Port_DiscountedBookFile"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "b6f81957-ad24-4312-98c2-27fb921e08ed", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "b6f81957-ad24-4312-98c2-27fb921e08ed", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "26e96ab9-4c51-43d0-bc3d-bf5fa00c68cf", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "26e96ab9-4c51-43d0-bc3d-bf5fa00c68cf", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "c96e6573-867d-445c-ab4d-3493ceb59c0b", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "c96e6573-867d-445c-ab4d-3493ceb59c0b", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,7,7,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,5,5,5,6,7,7,7,7,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __FileToFile_1 __ctx1__ = (__FileToFile_1)_stateMgrs[1];
            __FileToFile_root_0 __ctx0__ = (__FileToFile_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                Port_BookFileIn = new PortType_BookFileIn(0, this);
                Port_DiscountedBookFile = new PortType_DiscountedBookFile(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Port_BookFileIn, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __FileToFile_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __FileToFile_1 __ctx1__ = (__FileToFile_1)_stateMgrs[1];
            __FileToFile_root_0 __ctx0__ = (__FileToFile_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!Port_BookFileIn.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__MsgBook != null)
                    __ctx1__.UnrefMessage(__ctx1__.__MsgBook);
                __ctx1__.__MsgBook = new __messagetype_BTS2016FileToFile_Book("MsgBook", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__MsgBook);
                Port_BookFileIn.ReceiveMessage(0, __msgEnv__, __ctx1__.__MsgBook, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (Port_BookFileIn != null)
                {
                    Port_BookFileIn.Close(__ctx1__, __seg__);
                    Port_BookFileIn = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__MsgBook);
                    __edata.PortName = @"Port_BookFileIn";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                {
                    __messagetype_BTS2016FileToFile_DiscountedBook __MsgDiscountedBook = new __messagetype_BTS2016FileToFile_DiscountedBook("MsgDiscountedBook", __ctx1__);

                    ApplyTransform(typeof(BTS2016FileToFile.BookToDiscountedBook), new object[] {__MsgDiscountedBook.part}, new object[] {__ctx1__.__MsgBook.part});

                    if (__ctx1__.__MsgDiscountedBook != null)
                        __ctx1__.UnrefMessage(__ctx1__.__MsgDiscountedBook);
                    __ctx1__.__MsgDiscountedBook = __MsgDiscountedBook;
                    __ctx1__.RefMessage(__ctx1__.__MsgDiscountedBook);
                }
                __ctx1__.__MsgDiscountedBook.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__MsgDiscountedBook);
                    __edata.Messages.Add(__ctx1__.__MsgBook);
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__MsgBook != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MsgBook);
                    __ctx1__.__MsgBook = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_DiscountedBookFile.SendMessage(0, __ctx1__.__MsgDiscountedBook, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (Port_DiscountedBookFile != null)
                {
                    Port_DiscountedBookFile.Close(__ctx1__, __seg__);
                    Port_DiscountedBookFile = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__MsgDiscountedBook);
                    __edata.PortName = @"Port_DiscountedBookFile";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__MsgDiscountedBook != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MsgDiscountedBook);
                    __ctx1__.__MsgDiscountedBook = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 15;
            case 15:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __BTS2016FileToFile_Book__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static BTS2016FileToFile.Book _schema = new BTS2016FileToFile.Book();

        public __BTS2016FileToFile_Book__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "BTS2016FileToFile.Book",
        new System.Type[]{
            typeof(BTS2016FileToFile.Book)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__BTS2016FileToFile_Book__)
        },
        0,
        @"http://BTS2016.com.tr/FileToFile#Book"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_BTS2016FileToFile_Book : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __BTS2016FileToFile_Book__ part;

        private void __CreatePartWrappers()
        {
            part = new __BTS2016FileToFile_Book__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_BTS2016FileToFile_Book(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __BTS2016FileToFile_DiscountedBook__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static BTS2016FileToFile.DiscountedBook _schema = new BTS2016FileToFile.DiscountedBook();

        public __BTS2016FileToFile_DiscountedBook__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "BTS2016FileToFile.DiscountedBook",
        new System.Type[]{
            typeof(BTS2016FileToFile.DiscountedBook)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__BTS2016FileToFile_DiscountedBook__)
        },
        0,
        @"http://BTS2016.com.tr/FileToFile#DiscountedBook"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_BTS2016FileToFile_DiscountedBook : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __BTS2016FileToFile_DiscountedBook__ part;

        private void __CreatePartWrappers()
        {
            part = new __BTS2016FileToFile_DiscountedBook__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_BTS2016FileToFile_DiscountedBook(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
