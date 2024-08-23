/****************************************************************************************************
*  SolidTech Motion Library									    									*
*  Copyright (C) 2023 Shenzhen Solid Technology Co.,Ltd.			           						*
*																									*
*																									*
*  @file     sldmv.cs																				*
*  @brief    defs of struct and function															*
*																									*
*																									*
*  @version  20240220(x64�汾��)																		*
*  @date     2024.02.20																				*
*																									*
*																									*
****************************************************************************************************/
#define WIN32
//#define WIN64
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;




namespace ESLDM
{
	public class sldmv
	{
#if WIN64
		/***************************************************************************************************
		*			��������ֵ���京��
		***************************************************************************************************/
		/*���ݽṹ*/
		public static int SLDM_ERR_OK = 0;                 /*�޴���*/
		public static int SLDM_ERR_PMVAL = -1;             /*����ֵ����*/
		public static int SLDM_ERR_PULSEOVERFLOW = -2;             /*���巢�������*/
		public static int SLDM_ERR_PMID = -3;              /*����ID�����ڣ��޴˲���*/
		public static int SLDM_ERR_MCMAX = -4;             /*�����������ڣ�����ϵͳ֧�ֵ���������������*/
		public static int SLDM_ERR_CHMAX = -5;             /*ͨ���Ų����ڣ�����ϵͳ���ͨ����*/
		public static int SLDM_ERR_AXISMAX = -6;               /*��Ų����ڣ�����ϵͳ�������*/
		public static int SLDM_ERR_NOAUTH = -7;                /*����������Ȩ*/
		public static int SLDM_ERR_ADDROVERFLOW = -8;              /*������ַ���*/
		public static int SLDM_ERR_NOFLAG = -9;                /*û�д�״̬���־*/
		public static int SLDM_ERR_NONSTOPPED = -10;               /*�˶�û��ֹͣ*/
		public static int SLDM_ERR_MCNOFILE = -11;             /*�ļ��Ŵ�ʧ�ܡ��ļ��Ų����ڣ���SD�������ڡ�*/
		public static int SLDM_ERR_HOSTNOFILE = -12;               /*HOST���ļ�ʧ��*/
		public static int SLDM_ERR_AXISALM = -13;              /*���ŷ�����*/
		public static int SLDM_ERR_AXISPOT = -14;              /*������Ӳ��λ*/
		public static int SLDM_ERR_AXISNOT = -15;              /*�Ḻ��Ӳ��λ*/
		public static int SLDM_ERR_AXISPSL = -16;              /*����������λ*/
		public static int SLDM_ERR_AXISNSL = -17;              /*�Ḻ������λ*/
		public static int SLDM_ERR_AXISESTOP = -18;                /*Ӳ��ͣ*/
		public static int SLDM_ERR_AXISOT = -19;               /*��Ӳ��λ*/
		public static int SLDM_ERR_AXISSL = -20;               /*������λ*/
		public static int SLDM_ERR_PARANUM = -25;              /*����������������*/

		public static int SLDM_ERR_CURRENTPOS = -30;               /*����λ����岹λ��������*/
		public static int SLDM_ERR_ARCRADIUS = -32;                /*Բ���뾶������*/
		public static int SLDM_ERR_ENDPOS = -33;               /*�յ�λ�ô���*/
		public static int SLDM_ERR_INDEXMAX = -34;             /*���������Ŵ��󣬳������������*/
		public static int SLDM_ERR_ADDRMAX = -35;              /*������ַ�Ŵ��󣬳�������ַ��*/
		public static int SLDM_ERR_FUNCTIONEN = -36;               /*ģʽ����û��ʹ�ܻ��ʼ��*/
		public static int SLDM_ERR_BUFFENABLE = -37;               /*��������ֹ����*/
		public static int SLDM_ERR_BUFFMAX = -39;              /*������󻺳�������*/
		public static int SLDM_ERR_SPITIMEOVER = -40;              /*spiͨѶ��ʱ*/
		public static int SLDM_ERR_SPISYSTICKS = -41;              /*spi��������*/

		public static int PULSE_NUM_LESS_1 = -57;              /*�������С��1*/
		public static int PULSE_PERIOD_LESS_1 = -58;               /*��������С��1*/
		public static int OVERPPOS = -59;              /*����λ�����*/
		public static int OVERNPOS = -60;              /*����λ�����*/
		public static int PT_PLAN_OUT = -61;               /*PT�˶������������*/
		public static int HOMEING_MOVE = -62;              /*�����У�������λ����*/
		public static int BLOCK_EDGE_OUT = -63;                /*�������˶������������*/
		public static int BLOCK_EDGE_PTP1 = -64;               /*�������˶�ֱ�߲岹����*/
		public static int BLOCK_EDGE_ARC = -65;                /*�������˶�Բ���岹����*/
		public static int BLOCK_EDGE_RESTARTMOVE = -66;                /*�������˶�������������*/
		public static int BLOCK_ADD_POS = -67;             /*�������˶��ϳɾ���Ϊ0����*/

		public static int SLDM_ERR_OPEN = -90;             /*���ƿ���ʧ��*/
		public static int SLDM_ERR_OPENED = -91;               /*���ƿ��Ѿ���*/
		public static int SLDM_ERR_FREE = -92;             /*����ֱ���˳�*/
		public static int SLDM_ERR_IO_OVERTIME = -93;              /*������IOͨѶ��ʱ*/
		public static int SLDM_ERR_PC_IPADDR = -99;                /*PC IP��ַ����,��δ����*/

		public static int SLDM_ERR_FPGA_CMDBUFFFULL = -100;                /*FPGAָ�������*/
		public static int SLDM_ERR_COM_ADDR = -101;                /*��HOSTͨѶ���豸��ַ����*/
		public static int SLDM_ERR_COM_CHECKSUM = -102;                /*��HOSTͨѶ��У��ʹ���*/
		public static int SLDM_ERR_COM_INVCMD = -103;              /*��HOSTͨѶ������ID����*/
		public static int SLDM_ERR_SOCKET = -104;              /*HOST���У�SOCKET��ʼ��ʧ��*/
		public static int SLDM_ERR_SHM = -105;             /*HOST���У�SHM��ʼ��ʧ��*/
		public static int SLDM_ERR_PIPE = -106;                /*HOST���У�PIPE��ʼ��ʧ��*/
		public static int SLDM_ERR_NOLIBINITD = -107;              /*HOST��û�г�ʼ��*/
		public static int SLDM_ERR_NOMCOPEN = -108;                /*������δ��,��������ر�ʧ��*/
		public static int SLDM_ERR_MCOPEND = -109;             /*HOST���У��������Ѵ�*/
		public static int SLDM_ERR_MC_NONCONNECT = -110;               /*HOST�������ͨѶ��ʱ��δ����*/
		public static int SLDM_ERR_MC_CONNECTING = -111;               /*HOST���������������*/
		public static int SLDM_ERR_THREAD = -112;              /*HOST���У��̳߳�ʼ��ʧ��*/
		public static int SLDM_ERR_BUFFIDX = -113;             /*������������Ŵ���*/
		public static int SLDM_ERR_REFMESSAGE = -114;              /*�յ�������*/
		public static int SLDM_ERR_PREBUFFFULL = -115;             /*��׼������Ԥ��������*/
        public static int SLDM_ERR_BUFFFULL = -116;			/*��׼����黺������*/

        public static int SLDM_ERR_FB_TIMEOUT = -121;				/*�ŷ��ֳ����߳�ʱ*/
        public static int SLDM_ERR_FB_NCYCWNG = -122;				/*�ŷ������з���������ִ�б���*/
        public static int SLDM_ERR_FB_CCYCERR = -123;				/*�ŷ������з���������ִ�д���*/

		public static int SLDM_ERR_SERVICE_STOP = -230;                /*�������������ֹͣ*/
		public static int SLDM_ERR_UPDATE = -255;              /*�ڲ�ʹ�ã���������*/

		//@Begin ���ش���ID�ĺ������� ����
		public static int SLDM_OPEN_CODE = 0X01;   //1
		public static int SLDM_CLOSE_CODE = 0X02;  //2
		public static int SLDM_E2PROM_WRITE_CODE = 0X06;   //6
		public static int SLDM_E2PROM_READ_CODE = 0X07;    //7
		public static int SLDM_WRITE_REGCODE_CODE = 0X08;  //8
		public static int SLDM_READ_REGCODE_CODE = 0X09;   //9
		public static int SLDM_EXE2PROM_WRITE_CODE = 0X0A; //10
		public static int SLDM_EXE2PROM_READ_CODE = 0X0B;  //11
        public static int SLDM_FLASH_WRITE_CODE = 0X0C;	//12
        public static int SLDM_ERASE_NEWAPP = 0X0D;	//13
        public static int SLDM_SET_COMM_PERIOD = 0X0E; //14
		public static int SLDM_SET_DEBUG_MODE_CODE = 0X0F; //15

		public static int SLDM_SET_DIR_POL_CODE = 0X10;    //16
		public static int SLDM_SET_ENC_POL_CODE = 0X11;    //17
		public static int SLDM_SET_CPOS_CODE = 0X12;   //18
        public static int SLDM_SET_ENC_ENABLE = 0X13;	//19
		public static int SLDM_SET_ENC_CODE = 0X14;    //20
		public static int SLDM_SET_SERVOON_CODE = 0X1B;    //27
		public static int SLDM_SET_RSTALM_CODE = 0X1D; //29

		public static int SLDM_SET_PLIMIT_CONFIG_CODE = 0X20;  //32
		public static int SLDM_SET_NLIMIT_CONFIG_CODE = 0X21;  //33
		public static int SLDM_SET_ORG_CONFIG_CODE = 0X22; //34
		public static int SLDM_SET_SERVOALM_CONFIG_CODE = 0X23;    //35
		public static int SLDM_SET_SOFT_LIMIT_CODE = 0X24; //36
		public static int SLDM_RESET_CODE = 0X2E;  //46
		public static int SLDM_CLEAR_ALARM_HISTORY_CODE = 0X30;    //48
		public static int SLDM_SET_ENCZ_POL_CODE = 0X32;   //50
		public static int SLDM_SET_EMG_CONFIG_CODE = 0X33; //51
		public static int SLDM_SET_PULSE_MODE_CODE = 0X35; //53
		public static int SLDM_SET_PULSE_POL_CODE = 0X36;  //54
		public static int SLDM_SET_ENC_FILTER_CODE = 0X37; //55
		
		public static int SLDM_SET_SPEC_INPUT_FILTER_CODE = 0X39;  //57
		public static int SLDM_SET_AXIS_INPUT_FILTER_CODE = 0X3A;  //58

        public static int SLDM_PTPN_GROUP = 0x3E;	//62
        public static int SLDM_PTPN_STOP_GROUP = 0x3F;	//63

		public static int SLDM_SET_HOME_PARA_CODE = 0X50;  //80
		public static int SLDM_JOGA_CODE = 0X51;   //81
		public static int SLDM_PTP1_CODE = 0X52;   //82
		public static int SLDM_PTP1R_CODE = 0X53;  //83
		public static int SLDM_JOGP_CODE = 0X54;   //84
		public static int SLDM_JOGM_CODE = 0X55;   //85
		public static int SLDM_SET_HOME_OFT_CODE = 0X56;   //86
		public static int SLDM_STOP_CODE = 0X58;   //88
		public static int SLDM_ESTOP_CODE = 0X59;  //89
		public static int SLDM_CHANGE_POS_CODE = 0X5A; //90
		public static int SLDM_CHANGE_VEL_CODE = 0X5B; //91
		public static int SLDM_PTPN_CODE = 0X5C;   //92
		public static int SLDM_PTPN_STOP_CODE = 0X5D;  //93
		public static int SLDM_PMOVE_EXTERN_CODE = 0X5E;   //94
		public static int SLDM_HOME_MOVE_CODE = 0X5F;  //95

		public static int SLDM_SET_BUFF_ENABLE_CODE = 0X60;    //96
		public static int SLDM_START_BUFF_MOVE_CODE = 0X61;    //97
		public static int SLDM_ADD_BUFF_SEGMENT_CODE = 0X62;   //98
		public static int SLDM_RESET_BUFF_SEGMENT_P_CODE = 0X67;   //103
		public static int SLDM_SET_BUFF_MOVE_CURENT_P_CODE = 0X68; //104
		public static int SLDM_STOP_BUFF_MOVE_CODE = 0X69; //105
		public static int SLDM_SET_BUFF_MOVE_SINGLE_STEP_CODE = 0X6A;  //106
		public static int SLDM_RESET_BUFF_MOVE_CODE = 0X6B;    //107
		public static int SLDM_SETBUFFLOOP_CODE = 0X6D;    //109
		public static int SLDM_BUFF_WAIT_INPUT_CODE = 0X6E;    //110
		public static int SLDM_BUFF_DELAY = 0X6F;  //111

        public static int SLDM_TOGGLE_OUTBIT = 0X70;	//112
		public static int SLDM_SETOUTBIT_CODE = 0X73;  //115
		public static int SLDM_SETOUTBYTE_CODE = 0X76; //118
        public static int SLDM_SET_DI_FILTER_CODE = 0x7B;  //123
		public static int SLDM_SETOUTWORD = 0X7C;  //124
		public static int SLDM_SETOUTDWORD = 0X7D; //125
        public static int SLDM_IO_TRIGGER = 0x7E;	//126
		public static int SLDM_REVERSE_OUTBIT = 0X7F;  //127

		public static int SLDM_ARC_2D_CODE = 0X80; //128
		public static int SLDM_ARC_RADIUS_CODE = 0X81; //129
		public static int SLDM_ARC_STOP_CODE = 0X82;   //130
		public static int SLDM_ADD_MIX_SEGMENT_CODE = 0X83;    //131
		public static int SLDM_ADD_MIX_SEG_CODE = 0X84;    //132
		public static int SLDM_BUFF_DELAY_OUTBIT_TO_START_CODE = 0X85; //133
		public static int SLDM_BUFF_DELAY_OUTBIT_TO_STOP_CODE = 0X86;  //134
		public static int SLDM_BUFF_AHEAD_OUTBIT_TO_STOP_CODE = 0X87;  //135
		public static int SLDM_BUFF_CLEAR_IO_ACTION_CODE = 0X88;   //136
		public static int SLDM_ARC_3POlongS_CODE = 0X8A;    //138
		public static int SLDM_SET_GEAR_FOLLOW_CODE = 0X8B;    //139
		public static int SLDMPI_ARC_2DEX_CODE = 0X8C; //140
        public static int SLDM_PTPN_PLUS_CODE = 0X8E;//142
        public static int SLDM_PTPN_STOP_PLUS_CODE = 0X8F;	//143

		public static int SLDM_CMPR_ENABLE_CODE = 0X90;    //144
		public static int SLDM_CMPR_ADD_POlong_CODE = 0X91; //145
		public static int SLDM_CLEAR_CMPR_CODE = 0X93; //147
		public static int SLDM_START_CMPR_CODE = 0X94; //148
		public static int SLDM_COMPARELINEAR_CODE = 0X96;  //150
		public static int SLDM_CMPR_MOD_CODE = 0X97;   //151
		public static int SLDM_CMPR_2D_CODE = 0X98;    //152
		public static int SLDM_START_LATCH_CODE = 0X99;    //153
		public static int SLDM_SET_LATCH_PARA_CODE = 0X9A; //154
		public static int SLDM_CLEAR_LATCH_FIFO_CODE = 0X9C;   //156
        public static int SLDM_CMPR_3D_CODE = 0X9F;	//159

		public static int SLDM_PTINIT_CODE = 0XA0; //160
		public static int SLDM_PRFPT_CODE = 0XA1;  //161
		public static int SLDM_PTSTART_CODE = 0XA3;    //163
		public static int SLDM_PTDATA_CODE = 0XA4; //164
		public static int SLDM_PTCLEAR_CODE = 0XA5;    //165
		public static int SLDM_SETPTLOOP_CODE = 0XA6;  //166
		public static int SLDM_SETPTMEMORY_CODE = 0XAB;    //171

		public static int SLDM_SET_PWM_ENABLE_CODE = 0XB0; //176
		public static int SLDM_PWM_START_CODE = 0XB1;  //177
		public static int SLDM_SET_PWM_CONFIG_CODE = 0XB2; //178
															//public static int	SLDM_SET_GEAR_FOLLOW_CODE		=			0XB6;	//182(���жϵ�����)
		public static int SLDM_BUFF_SET_PWM_OUTPUT = 0XB4; //180
		public static int SLDM_BUFF_SET_PWM_ONOFF_DUTY = 0XB5; //181
		public static int SLDM_BUFF_SET_PWM_FOLLOW_SPEED = 0XB6;   //182
		public static int SLDM_BUFF_DELAY_PWM_TO_START = 0XB7; //183
		public static int SLDM_BUFF_AHEAD_PWM_TO_STOP = 0XB8;  //184

        public static int SLDM_SET_HANDWHEEL_CONFIG = 0XBD;//189
        public static int SLDM_SET_HANDWHEEL_MAXVEL = 0XBE;	//190
        public static int SLDM_SET_HANDWHEEL_ENABLE = 0XBF;	//191

        public static int SLDM_SET_ECAT_AXIS = 0XC0;	//192
        public static int SLDM_ECAT_RESET = 0XC1;	//193

		public static int SLDM_TEST_FUNCTION_CODE = 0XFF;  //255
															//@End ���ش���ID�ĺ������� ����=

		//@Begin PT�˶�ģʽ
		public static int PT_MODE_STATIC = 0;//���ú궨��Ϊ 0����̬ģʽ��Ĭ��Ϊ��ģʽ��
		public static int PT_MODE_DYNAMIC = 1;//���ú궨��Ϊ 1����̬ģʽ
		public static int PT_SEGMENT_NORMAL = 0;//���ú궨��Ϊ 0����ͨ�Ρ�Ĭ��Ϊ�����͡�
		public static int PT_SEGMENT_EVEN = 1;//���ú궨��Ϊ 1�����ٶΡ�
		public static int PT_SEGMENT_STOP = 2;//���ú궨��Ϊ 2�����ٵ� 0 �Ρ�
		public static int PT_SEGMENT_END = 3;// �Զ��������־
											  //@End PT�˶�ģʽ

		public static int MAX_ALM_BUFFER_NUM = 256;



        [StructLayout(LayoutKind.Sequential)]
        public struct CARD_INFO
        {
            public UInt32 Card_ID;
            public UInt32 Lib_SoftVer;
            public UInt32 Arm_SoftVer;
            public UInt32 Arm_GitCommit;
            public UInt32 FPGA_SoftVer;
            public UInt32 FPGA_GitCommit;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public UInt32[] FPGA_UID;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public UInt32[] Arm_UID;
            public UInt32 PCB_Ver;
            public UInt32 PCB_GitCommit;
            public UInt32 BOM_Ver;
            public UInt32 BOM_GitCommit;
            public UInt32 Slave_Type;

        }


		[StructLayout(LayoutKind.Sequential)]
		public struct Jump_Data
		{
			public UInt32 axis_count;               //3,�̶�3��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public uint[] axis_list;     //��ǰָ�������Զ�3������в���;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
			public int[] target_pos;         //����Ŀ��λ�ã���������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public int[] start_pos;          //���λ�ã���������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
			public short[] soft_en;               //�Ƿ�����������������½��־��soft_en[0]-������,soft_en[0]-����½��
			public int soft_upZPos;               //̧������У�������Z��λ������
			public int soft_downZPos;             //�½������У�����½Z��λ������
			public float soft_upVel;               //̧������У��������յ��ٶ�
			public float soft_downVel;             //�½������У�����½�յ��ٶ�
			public int z_sofePos;                 //Z�����½���̧������У���ȫλ��
			public int z_steadyPos;               //Z����Ƹ߶�
			public float start_vel;                //�������˶�����ʼ�ٶ�
			public float end_vel;                  //�������˶����յ��ٶ�
			public float steady_vel;               //�������˶�������ٶ�
			public float move_acc;                 //�˶������еļ��ٶȣ�pulse/ms^2
			public float move_dec;                 //�˶������еļ��ٶȣ�pulse/ms^2
		}


		public struct Axis_Para
		{
            public bool servo_alarm_en;
            public bool Plimit_en;
            public bool Nlimit_en;
            public bool origin_en;

            public bool servo_alarm_pol;
            public bool Plimit_pol;
            public bool Nlimit_pol;
            public bool origin_pol;

            public bool Dir_pol;
            public bool Enc_pol;
            public bool Encz_pol;

            public bool soft_Plimit_en;
            public bool soft_Nlimit_en;
            public bool pulse_Pol;
            public byte Pulse_Mode;//2 bit

            public int soft_Plimit_pos;
            public int soft_Nlimit_pos;
            public int home_oft_pos;
            public int i_zcap_pulse;//E516 @
		}

		public struct Axis_Status
		{
            public byte servo_alarm_vol;
            public byte Plimit_vol;
            public byte Nlimit_vol;
            public byte origin_vol;
            public byte Encz_vol;
            public byte reached_vol;
            public byte servon;
            public byte resalm;

            public byte servo_alarm_valid;
            public byte Plimit_valid;
            public byte Nlimit_valid;
            public byte origin_valid;
            public byte Encz_valid;
            public byte reached_valid;
            public byte soft_Plimit_valid;
            public byte soft_Nlimit_valid;

            public byte homing;
            public byte homed;
            public byte running;

            public byte alarm_status;//0x01����λ��0x02����λ��0x04 soft_plimit,0x08 soft_nlimit,0x10�ŷ�����
            public byte home_flag;

		}

        [StructLayout(LayoutKind.Sequential)]
        public struct Alarm_History
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public int[] alarm_number;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public int[] alarm_para;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public int[] time_tick;

        }

        public struct Home_Para
        {
            public uint h_dir;
            public uint mode;
            public float low_vel;
            public float high_vel;
            public float acc;
            public uint enc_en;
        }

		public delegate void fn();



		/**********************************************************************************
		* @Begin E450
		***********************************************************************************/
		//********************************************************************************************************************************************************************
        /**
        * @brief ���ÿ����������������ͺ��б�
        * @param IP_4��      ����IP��ַ��4λ������IP��ַǰ3λ������192.168.100.
         *       card_num��   ��������������.
        *        type��		  �����������ͺ��б�����
        *						450-E450
        *						6364-E6364
        *						6564-E6564
        *						......
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Card_List(ulong IP_4,ulong card_num,  UInt32[] type);
		//********************************************************************************************************************************************************************
        /**
        * @brief ��ȡ�����������������ͺ��б�
        * @param IP_4��      ����IP��ַ��4λ������IP��ַǰ3λ������192.168.100.
         *       card_num��   ���ؼ�������������.
        *        type��		  ���ؿ����������ͺ��б�����
        *						450-E450
        *						6364-E6364
        *						6564-E6564
        *						......
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Get_Card_List(UInt32 IP_4, ref UInt32 card_num, [Out] UInt32[] type);

		/*
		         * @brief ��ȡ�����������������ͺ��б�
		         * SLDM_Get_Card_List_IP �˺�����ʱ�޷�����
		         * 
        * @param 
        *		 IP_1��      ����IP��ַ��1λ        
        *		 IP_2��      ����IP��ַ��2λ        
        *		 IP_3��      ����IP��ַ��3λ
        *		 IP_4��      ����IP��ַ��4λ
        *		 ip_4��      ��ip��ַ����λ      		 
        *        cardlist_num��   ���ؼ�������������.
        *        type��		  ���ؿ����������ͺ��б�����
        *						450-E450
        *						6364-E6364
        *						6564-E6564
        *						......
        * @return �ɹ�����0.
        * @remark
		 */
		//sldmv.SLDM_Get_Card_List_IP(PC_IP_1, PC_IP_2, PC_IP_3, PC_IP_4, ip_4, &cardlist_num, type);
		//public static extern long SLDM_Get_Card_List(ref ulong card_num, ref UInt32[] type);
		[DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Card_List_IP(UInt32 IP_1, UInt32 IP_2, UInt32 IP_3, UInt32 IP_4, UInt32 ip_4, ref UInt32 cardlist_num , [Out] UInt32[] type);

		/**********************************************************************************
		* @End E450
		***********************************************************************************/


		/***************************************************************************************************
		*		�����ӿ�
		***************************************************************************************************/

		/**********************************************************************************
		* @Begin ����������
		***********************************************************************************/

		//********************************************************************************************************************************************************************
		/**
        * @brief �򿪿�����
        * @param IP_4��      ����IP��ַ��4λ������IP��ַǰ3λ������192.168.100.
        *        type��      ��̫�����䷽ʽ,ȡֵ��Χ��
        *						0-UDP (Ĭ��)
        *						1-wincap
        * @return �ɹ�����0.
        * @remark
        */
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Open(ulong IP_4, ulong type = 0);
		/// <summary>
		/// �򿪿��ƿ�
		/// </summary>
		/// <param name="PC_IP_1"></param>������ַ 1
		/// <param name="PC_IP_2"></param>������ַ 2
		/// <param name="PC_IP_3"></param>������ַ 3
		/// <param name="PC_IP_4"></param>������ַ 4
		/// <param name="ip_4"></param>�ӻ�/�� ip��ַ 4
		/// <returns> �ɹ����� 0
		/// </returns>
		[DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Open_IP(UInt32 PC_IP_1, UInt32 PC_IP_2, UInt32 PC_IP_3, UInt32 PC_IP_4, UInt32 ip_4);
		//       public static extern int SLDM_Open(ulong IP_4, ulong card_no, ulong type = 0);
		//********************************************************************************************************************************************************************
		/**
		* @brief �رտ�����
		* @param card_no��   0
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Close(UInt32 card_no);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ÿ�������СͨѶ����
		* @param card_no��	0
		*		 period��	��СͨѶ����ģʽ����λus��ȡֵ��Χ��0-1000.Ĭ��ֵ800.
		* @return �ɹ�����0.
		* @remark ����ģʽʱ��������������ͨѶ���ڹ�����������
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Comm_Period(UInt32 card_no, UInt32 period);//us
																					//********************************************************************************************************************************************************************
		/**
		* @brief ���ÿ���������ģʽ
		* @param card_no��	0
		*		 model��	ģʽ��0-�ǵ���ģʽ��1-����ģʽ
		* @return �ɹ�����0.
		* @remark ����ģʽʱ��������������ͨѶ���ڹ�����������
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Debug_Mode(UInt32 card_no, UInt32 mode);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ����������
		* @param card_no��	0
		*		 ticks��	���ؿ���������ֵ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_SysTicks(UInt32 card_no, ref UInt32 ticks);

		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ������������״̬
		* @param card_no��	�����Ŀ���
		*		 status��	���ؿ�����������״̬��
		*						0-������
		*						-1-δ����
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_ConnStatus(UInt32 card_no, ref int status);

		/**********************************************************************************
		* @End ����������
		***********************************************************************************/

		/**********************************************************************************
		* @Begin �������״̬��д
		***********************************************************************************/

		//********************************************************************************************************************************************************************
		/**
		* @brief ���ÿ�����IP��ַ��Ĭ�ϵ�ַΪ192.168.100.1��
		* @param card_no��	0
		*		 IP_1��	IP��ַ��һλ����ӦĬ�ϵ�ַΪ192
		*		 IP_2��	IP��ַ�ڶ�λ����ӦĬ�ϵ�ַΪ168
		*		 IP_3��	IP��ַ����λ����ӦĬ�ϵ�ַΪ100
		*		 IP_4��	IP��ַ����λ����ӦĬ�ϵ�ַΪ1
		* @return �ɹ�����0.
		* @remark ����ģʽʱ��������������ͨѶ���ڹ�����������
		*/
		[DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_IP(UInt32 card_no, UInt32 IP_1 , UInt32 IP_2 , UInt32 IP_3 , UInt32 IP_4 );
		//********************************************************************************************************************************************************************

		//********************************************************************************************************************************************************************
		/**
		* @brief �����������ģʽ
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 mode��		ģʽֵ��
		*						0-����+����
		*						1-AB��
		*						2-˫����
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Pulse_Mode(UInt32 card_no, UInt32 axis, UInt32 mode);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���������弫��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pol��		����ֵ��
		*						0-������ (Ĭ��)
		*						1-������
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Pulse_Pol(UInt32 card_no, UInt32 axis, UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���������巽����
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pol��		����ֵ��
		*						0-������ (Ĭ��)
		*						1-������
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Dir_Pol(UInt32 card_no, UInt32 axis, UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief �����������������
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pol��		����ֵ��
		*						0-������ (Ĭ��)
		*						1-������
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Enc_Pol(UInt32 card_no, UInt32 axis, UInt32 pol);
        //********************************************************************************************************************************************************************
        /**
        * @brief �����������ʹ��
        * @param card_no��	�����Ŀ���
        *		 axis��		��ѡ��(0-3)
        *		 en��		ʹ��ֵ��
        *						0-��ʹ��
        *						1-ʹ�� (Ĭ��)
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Set_Enc_Enable(UInt32 card_no, UInt32 axis, UInt32 en);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ö�ȡ��������������
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 mult��		��������ֵ��Ĭ��ֵ4��4��Ƶ��.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Enc_Mult(UInt32 card_no, UInt32 axis, UInt32 mult);
		//********************************************************************************************************************************************************************
		/**
		* @brief �����ᵱǰλ��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pos��		λ�� ����λ������.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Cpos(UInt32 card_no, UInt32 axis, int pos);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�ᵱǰλ��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pos��		���ص�ǰλ�� ����λ������.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Pos(UInt32 card_no, UInt32 axis, ref Int32 pos);
		//********************************************************************************************************************************************************************
		/**
		* @brief �����ᵱǰ������λ��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pos��		λ�� ����λ������.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Enc(UInt32 card_no, UInt32 axis, int pos);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�ᵱǰ������λ��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pos��		���ص�ǰ������λ�� ����λ������.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Get_Enc(UInt32 card_no, UInt32 axis, ref Int32 pos);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ñ�����Z�źŲ���
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pol��		��Ч��ƽ��0-�͵�ƽ��1-�ߵ�ƽ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_EncZ_Pol(UInt32 card_no, UInt32 axis, UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ������Z�źŵ�ƽ
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 valid��	���ر�����z�ź���Ч״̬��0-��Ч��1-��Ч.
		*		 el��		���ر�����z�źŵ�ƽ��0-�͵�ƽ��1-�ߵ�ƽ.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Enc_Z(UInt32 card_no, UInt32 axis, ref UInt32 valid, ref UInt32 el);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ü�ͣ����
		* @param card_no��	�����Ŀ���
		*		 en��		ʹ�� 0-��ʹ�ܣ�1-ʹ�� (Ĭ�ϲ�ʹ��)
		*		 pol��		��ͣ��Чֵ��0-���벻��ͨ��1-���뵼ͨ (Ĭ��1-���뵼ͨ)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_EMG_Config(UInt32 card_no, UInt32 en, UInt32 pol);

		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ��ͣ����
		* @param card_no��	�����Ŀ���
		*		 en��		ʹ�� 0-��ʹ�ܣ�1-ʹ�� 
		*		 pol��		��ͣ��Чֵ��0-���벻��ͨ��1-���뵼ͨ 
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_EMG_Config(UInt32 card_no, ref UInt32 en, ref UInt32 pol);

		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ��ͣ�ź�״̬
		* @param card_no��	�����Ŀ���
		*		 valid��	���ر�����z�ź���Ч״̬��0-��Ч��1-��Ч.
		*		 el��		���ر�����z�źŵ�ƽ��0-�͵�ƽ��1-�ߵ�ƽ.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_EMG(UInt32 card_no, ref UInt32 valid, ref UInt32 el);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ø����ŷ�ʹ��״̬
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 on��		ʹ�ܶ˿ڵ�ͨ״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_ServoOn(UInt32 card_no, UInt32 axis, UInt32 on);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�����ŷ�ʹ��״̬
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 on��		����ʹ�ܶ˿ڵ�ͨ״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_ServoOn(UInt32 card_no, UInt32 axis, ref UInt32 on);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ø����ŷ��������״̬
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 on��		��������˿ڵ�ͨ״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_RstAlm(UInt32 card_no, UInt32 axis, UInt32 on);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�����ŷ��������״̬
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 on��		��������˿ڵ�ͨ״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_RstAlm(UInt32 card_no, UInt32 axis, ref UInt32 on);
		//********************************************************************************************************************************************************************
		/**
		* @brief ����������λ����
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 en��		ʹ�� 0-��ʹ�ܣ�1-ʹ�� (Ĭ�ϲ�ʹ��)
		*		 pol��		��λ��Чֵ��0-���벻��ͨ��1-���뵼ͨ (Ĭ��1-���뵼ͨ)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Plimit_Config(UInt32 card_no, UInt32 axis, UInt32 en, UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ������λ����
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 en��		����ʹ��״̬ 0-��ʹ�ܣ�1-ʹ�� (Ĭ�ϲ�ʹ��)
		*		 pol��		������λ��Чֵ״̬��0-���벻��ͨ��1-���뵼ͨ (Ĭ��1-���뵼ͨ)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Plimit_Config(UInt32 card_no, UInt32 axis, ref UInt32 en, ref UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ����������λ����״̬
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 valid��	������λ��Ч״ֵ̬ 0-��Ч��1-��Ч
		*		 el��		������λ�ӿڵ�ͨ״ֵ̬0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_POT(UInt32 card_no, UInt32 axis, ref UInt32 valid, ref UInt32 el);
		//********************************************************************************************************************************************************************
		/**
		* @brief �����Ḻ��λ����
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 en��		ʹ�� 0-��ʹ�ܣ�1-ʹ�� (Ĭ�ϲ�ʹ��)
		*		 pol��		��λ��Чֵ��0-���벻��ͨ��1-���뵼ͨ (Ĭ��1-���뵼ͨ)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Nlimit_Config(UInt32 card_no, UInt32 axis, UInt32 en, UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�Ḻ��λ����
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 en��		����ʹ��״̬ 0-��ʹ�ܣ�1-ʹ�� (Ĭ�ϲ�ʹ��)
		*		 pol��		������λ��Чֵ״̬��0-���벻��ͨ��1-���뵼ͨ (Ĭ��1-���뵼ͨ)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Nlimit_Config(UInt32 card_no, UInt32 axis, ref UInt32 en, ref UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ���Ḻ����λ����״̬
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 valid��	������λ��Ч״ֵ̬ 0-��Ч��1-��Ч
		*		 el��		������λ�ӿڵ�ͨ״ֵ̬0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_NOT(UInt32 card_no, UInt32 axis, ref UInt32 valid, ref UInt32 el);
		//********************************************************************************************************************************************************************
		/**
		* @brief ������ԭ�����
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 en��		ʹ�� 0-��ʹ�ܣ�1-ʹ�� (Ĭ�ϲ�ʹ��)
		*		 pol��		ԭ����Чֵ��0-���벻��ͨ��1-���뵼ͨ (Ĭ��1-���뵼ͨ)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Org_Config(UInt32 card_no, UInt32 axis, UInt32 en, UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ��ԭ�����
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 en��		����ʹ��״̬ 0-��ʹ�ܣ�1-ʹ�� (Ĭ�ϲ�ʹ��)
		*		 pol��		����ԭ����Чֵ״̬��0-���벻��ͨ��1-���뵼ͨ (Ĭ��1-���뵼ͨ)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Org_Config(UInt32 card_no, UInt32 axis, ref UInt32 en, ref UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ����ԭ�㿪��״̬
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 valid��	����ԭ�㿪����Ч״ֵ̬ 0-��Ч��1-��Ч
		*		 el��		����ԭ�㿪�ؽӿڵ�ͨ״ֵ̬0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Org(UInt32 card_no, UInt32 axis, ref UInt32 valid, ref UInt32 el);
		//********************************************************************************************************************************************************************
		/**
		* @brief �������ŷ���������
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 en��		ʹ�� 0-��ʹ�ܣ�1-ʹ�� (Ĭ�ϲ�ʹ��)
		*		 pol��		���ŷ�������Чֵ��0-���벻��ͨ��1-���뵼ͨ (Ĭ��1-���뵼ͨ)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_ServoAlm_Config(UInt32 card_no, UInt32 axis, UInt32 en, UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ���ŷ���������
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 en��		����ʹ��״̬ 0-��ʹ�ܣ�1-ʹ�� (Ĭ�ϲ�ʹ��)
		*		 pol��		���ر�����Чֵ״̬��0-���벻��ͨ��1-���뵼ͨ (Ĭ��1-���뵼ͨ)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_ServoAlm_Config(UInt32 card_no, UInt32 axis, ref UInt32 en, ref UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�����ŷ���������״̬
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 valid��	�����ŷ���������Ч״ֵ̬ 0-��Ч��1-��Ч
		*		 el��		�����ŷ������ӿڵ�ͨ״ֵ̬0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Servo_Alarm(UInt32 card_no, UInt32 axis, ref UInt32 valid, ref UInt32 el);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ���᷽���Բ���
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 Dir_pol��	�������巽������״̬ 0-������1-������
		*		 Pulse_Pol���������弫������״̬ 0-�����ԣ�1-������
		*		 Enc_pol��	���ر�������������״̬ 0-�����ԣ�1-������
		*		 Encz_pol��	���ر�����Z�źż�������״̬ 0-�����ԣ�1-������
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_AxisPol_Config(UInt32 card_no, UInt32 axis, ref UInt32 Dir_pol, ref UInt32 Pulse_Pol, ref UInt32 Enc_pol, ref UInt32 Encz_pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ��������ṹ
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 p_axispara������������ṹ��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Axis_Para(UInt32 card_no, UInt32 axis, ref Axis_Para p_axispara);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ñ������˲�ʱ��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 filter_time���˲�ʱ�䣬��λus��Ĭ��ֵ0.2-20ns.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Enc_Filter(UInt32 card_no, UInt32 axis, float filter_time);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��������������˲�ʱ��
		* @param card_no��	�����Ŀ���
		*		 input_bit��DIλѡ��(0-15)
		*		 filter_time���˲�ʱ�䣬��λus��Ĭ��ֵ1-1us.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_DI_Filter(UInt32 card_no, UInt32 input_bit, float filter_time);
		//********************************************************************************************************************************************************************
		/**
		* @brief ������λ��ԭ�㡢��λ�����ź��˲�ʱ��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 filter_time���˲�ʱ�䣬��λus��Ĭ��ֵ1000-1ms.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Spec_Input_Filter(UInt32 card_no, UInt32 axis, float filter_time);
		//********************************************************************************************************************************************************************
		/**
		* @brief �����ᱨ���ź��˲�ʱ��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 filter_time���˲�ʱ�䣬��λus��Ĭ��ֵ1000-1ms.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Axis_Input_Filter(UInt32 card_no, UInt32 axis, float filter_time);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ���˶���Ŀ��λ��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pos��		���ص�ǰ�˶�Ŀ��λ�� ����λ������.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_PosT(UInt32 card_no, UInt32 axis, ref int pos);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ���˶��Ĺ켣�滮λ��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pos��		���ص�ǰ�˶��켣�滮λ�� ����λ������.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_PosA(UInt32 card_no, UInt32 axis, [Out] int pos);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ���˶��ٶ�
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 vel��		�����ᵱǰ�ٶȣ���λ��p/ms
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Vel(UInt32 card_no, UInt32 axis, ref float vel);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡֱ�߲岹��Բ���岹�˶��ٶ�
		* @param card_no��	�����Ŀ���
		*		 line_vel��	����ֱ�߲岹��ǰ�ٶȣ���λ��p/ms
		*		 arc_vel��	����Բ���岹��ǰ�ٶȣ���λ��p/ms
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_ExVel(UInt32 card_no, ref float line_vel, ref float arc_vel);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ����λԭ���״̬�ṹ��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 p_axissatus��������״̬�ṹ��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Axis_Status(UInt32 card_no, UInt32 axis, ref Axis_Status p_axissatus);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ���ᵽλ����״̬
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 valid��	���ص�λ������Ч״ֵ̬ 0-��Ч��1-��Ч
		*		 el��		���ص�λ���ؽӿڵ�ͨ״ֵ̬0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Reached(UInt32 card_no, UInt32 axis, ref UInt32 valid, ref UInt32 el);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�������˶�״̬
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 running��	�������˶�״̬��0-ֹͣ��1-�˶�
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Running(UInt32 card_no, UInt32 axis, ref UInt32 running);
		//********************************************************************************************************************************************************************
		/**
		* @brief �Ḵλ
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Reset(UInt32 card_no, UInt32 axis);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�����ۺϱ�����Ϣ
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 p_almstatus�����ظ��ᱨ����Ϣ״̬
		* @return �ɹ�����0.
		* @remark 0x01����λ��0x02����λ��0x04 ������λ,0x08 ������λ,0x10�ŷ�����
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Axis_AlmStatus(UInt32 card_no, UInt32 axis, ref UInt32 p_almstatus);
		//********************************************************************************************************************************************************************
        /**
        * @brief ��ȡ����ʷ������Ϣ
        * @param card_no��	�����Ŀ���
        *		 p_alarmhistory����������ʷ�����ṹ
        * @return ������ʷ��������.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Alarm_History(UInt32 card_no, ref Alarm_History p_alarmhistory);
		//********************************************************************************************************************************************************************
		/**
		* @brief �������ʷ������Ϣ
		* @param card_no��	�����Ŀ���
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Clear_Alarm_History(UInt32 card_no);
		//********************************************************************************************************************************************************************
        /**
        * @brief ��ȡ���������һ�ε���ʷ������Ϣ
        * @param card_no��	�����Ŀ���
        *		 p_Alarm_number�����ر�����־
        *		 p_Alarm_para�����ر�������
        *		 p_time_tick�����ر�������
        * @return ������ʷ��������.
        * @remark 0x01����λ��0x02����λ��0x04 ������λ,0x08 ������λ,0x10�ŷ�����
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_AlarmHistory(UInt32 card_no, [Out] int[] p_Alarm_number, [Out] int[] p_Alarm_para, [Out] int[] p_time_tick);

		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�������Ϣ
		* @param card_no��	�����Ŀ���
		*		 err��		�����������룬��������0.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Move_Error(UInt32 card_no, ref int err);

		/**********************************************************************************
		* @End �������״̬��д
		***********************************************************************************/

		/**********************************************************************************
		* @Begin ����
		***********************************************************************************/


		//********************************************************************************************************************************************************************
		/**
		* @brief ���������ƫ�ò���
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pos��		����ƫ��λ�ã���λ������.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Home_Oft(UInt32 card_no, UInt32 axis, int pos);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��������λ����
		* @param card_no��	�����Ŀ���
		*		 axis_mask����λ�����ʾ����ѡ��
		*		 en��		����ƫ��λ�ã���λ������.
		*		 p_pos��	����λλ�ã���λ������
		*		 n_pos��	����λλ�ã���λ������
		* @return �ɹ�����0.
		* @remark ����λ�ڻ�����ɺ���Ч
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Soft_Limit(UInt32 card_no, UInt32 axis, UInt32 en, int p_pos, int n_pos);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ��������λ����
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 en��		��������λʹ������״̬ 0-��ʹ�ܣ�1-ʹ��
		*		 p_pos��	����������λλ��
		*		 n_pos��	���ظ�����λλ��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Soft_Limit(UInt32 card_no, UInt32 axis, ref UInt32 en, ref int p_pos, ref int n_pos);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���û������
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 h_dir��	���㷽��0-����1-����.
		*		 low_vel��	�����ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 high_vel��	�����ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000.
		*		 mode��		����ģʽ��
		*                       0- ԭ�ػ���
		*                       1- һ��ԭ�����
		*                       2- һ����λ����
		*                       3- һ��ԭ�����ӻ���
		*                       4- һ����λ����ӻ���
		*                       5- ����ԭ�����
		*                       6- ������λ����
		*                       7- EZ �źŻ���
		*                       8- ԭ�������ٻ��� EZ �ź�
		*                       9- ��λ������ٻ��� EZ �ź�
		*                       10- ԭ������
		*                       11- ��λ����
		*                       12- EZ�ź� ����
		*                       13- ԭ�����ӷ��� EZ ����
		*                       14- ��λ����ӷ��� EZ ����
		*		 enc_en��	���ñ�������Ч��0-��Ч��1-��Ч
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Home_Para(UInt32 card_no, UInt32 axis, UInt32 h_dir, float low_vel, float high_vel, float acc, UInt32 mode, UInt32 enc_en);

		//********************************************************************************************************************************************************************
		/**
		* @brief ���������˶�
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Home_Move(UInt32 card_no, UInt32 axis);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�����״̬
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 homing��	�����������״̬��0-���ڻ�������У�1-�ڻ��������
		*		 homed��	������������״̬��0-����δ��ɣ�1-�������
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Homing(UInt32 card_no, UInt32 axis, ref UInt32 homing, ref UInt32 homed);

		/**********************************************************************************
		* @End  ����
		***********************************************************************************/


		/**********************************************************************************
		* @Begin �����˶�
		***********************************************************************************/

		//********************************************************************************************************************************************************************
		/**
		* @brief ��������ʽ P2P �˶�
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pos��		Ŀ��λ�ã���λ pulse����Χ-2 31 ~2 31
		*		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 sine��		�������ߣ�0-T�ͣ�1-S��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_JogA(UInt32 card_no, UInt32 axis, int pos, float start_vel, float steady_vel, float acc, UInt32 sine);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��������ʽ P2P �˶����ǶԳƵ�λ�˶���
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pos��		Ŀ��λ�ã���λ pulse����Χ-2 31 ~2 31
		*		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 end_vel��	�յ��ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 dec��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 sine��		�������ߣ�0-T�ͣ�1-S��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PTP1(UInt32 card_no, UInt32 axis, Int32 pos, float start_vel, float steady_vel, float end_vel, float acc, float dec, UInt32 sine);

		//********************************************************************************************************************************************************************
		/**
		* @brief �������ʽ P2P �˶����ǶԳƵ�λ�˶���
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pos��		���Ŀ��λ�ã���λ pulse����Χ-2 31 ~2 31
		*		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 end_vel��	�յ��ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 dec��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 sine��		�������ߣ�0-T�ͣ�1-S��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PTP1R(UInt32 card_no, UInt32 axis, int pos, float start_vel, float steady_vel, float end_vel, float acc, float dec, UInt32 sine);
		//********************************************************************************************************************************************************************
		/**
		* @brief �������������˶�
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 acc��		Ŀ���(��)�ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_JogP(UInt32 card_no, UInt32 axis, float start_vel, float steady_vel, float acc);
		//********************************************************************************************************************************************************************
		/**
		* @brief �������������˶�
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 acc��		Ŀ���(��)�ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_JogM(UInt32 card_no, UInt32 axis, float start_vel, float steady_vel, float acc);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���˶�����ֹͣ����� P2P��Jog��Home ���˶�
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 stop_dec��	����ֹͣ���ٶȣ����Ϊ������Ĭ�ϼ��ٶ�ֹͣ.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Stop(UInt32 card_no, UInt32 axis, float stop_dec);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���˶�����ֹͣ����� P2P��Jog��Home ���˶�
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Estop(UInt32 card_no, UInt32 axis);
		//********************************************************************************************************************************************************************
		/**
		* @brief �ı����˶��յ�λ��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pos��		Ŀ��λ�ã���λ pulse����Χ-2 31 ~2 31
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Change_Pos(UInt32 card_no, UInt32 axis, int pos);
		//********************************************************************************************************************************************************************
		/**
		* @brief �ı����˶��ٶ�
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 vel��		Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Change_Vel(UInt32 card_no, UInt32 axis, float vel);
		/**********************************************************************************
		* @End �����˶�
		***********************************************************************************/


		/**********************************************************************************
		* @Begin �����˶�
		***********************************************************************************/
		//********************************************************************************************************************************************************************
		/**
		* @brief ����ֱ�ߵ�λ�˶�
		* @param card_no��	�����Ŀ���
		*		 n_axis��	�˶������1-7
		*		 p_axis��	�������
		*		 pos��		����Ŀ��λ�����飬��λ pulse����Χ-2 31 ~2 31
		*		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000		
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000		
		*		 end_vel��	�յ��ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000	
		*		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 dec��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 sine��		�������ߣ�0-T�ͣ�1-S��		
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PTPn(UInt32 card_no, UInt32 n_axis,  UInt32[] axislist,  Int32[] pos, float start_vel, float steady_vel, float end_vel, float acc, float dec, UInt32 sine);
		//********************************************************************************************************************************************************************
		/**
		* @brief ����ֱ�ߵ�λ�˶�
		* @param card_no��	�����Ŀ���
		*		 stop_dec��	����ֹͣ���ٶȣ����Ϊ������Ĭ�ϼ��ٶ�ֹͣ.	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PTPn_Stop(UInt32 card_no, float stop_dec);
        //********************************************************************************************************************************************************************
        /**
        * @brief ����ŵĶ���ֱ�ߵ�λ�˶�
        * @param card_no��	�����Ŀ���
        *		 group_id��	��ţ�������������ţ�ÿ������˶���ֹͣ.��Χ��0-�������/2
        *		 n_axis��	�˶������1-7
        *		 p_axis��	�������
        *		 pos��		����Ŀ��λ�����飬��λ pulse����Χ-2 31 ~2 31
        *		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000		
        *		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000		
        *		 end_vel��	�յ��ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000	
        *		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
        *		 dec��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
        *		 sine��		�������ߣ�0-T�ͣ�1-S��		
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_PTPn_Group(UInt32 card_no, UInt32 group_id, UInt32 n_axis, UInt32[] axislist, Int32[] pos, float start_vel, float steady_vel, float end_vel, float acc, float dec, UInt32 sine);
        //********************************************************************************************************************************************************************
        /**
        * @brief ֹͣ����ֱ�ߵ�λ�˶�
        * @param card_no��	�����Ŀ���
        *		 group_id��	��ţ�������������ţ�ÿ������˶���ֹͣ.��Χ��0-�������/2
        *		 stop_dec��	����ֹͣ���ٶȣ����Ϊ������Ĭ�ϼ��ٶ�ֹͣ.	
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_PTPn_Stop_Group(UInt32 card_no, UInt32 group_id, float stop_dec);
        //********************************************************************************************************************************************************************
        /**
        * @brief ����ֱ�ߵ�λ�˶�����չ������������滮��ʽ��
        * @param card_no��	�����Ŀ���
        *		 n_axis��	�˶������1-7
        *		 p_axis��	�������
        *		 pos��		����Ŀ��λ�����飬��λ pulse����Χ-2 31 ~2 31
        *		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000		
        *		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000		
        *		 end_vel��	�յ��ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000	
        *		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
        *		 dec��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
        *		 sine��		�������ߣ�0-T�ͣ�1-S��		
        * @return �ɹ�����0.
        * @remark ��SLDM_PTPn_Stop_Plus ���ʹ��
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_PTPn_Plus(UInt32 card_no, UInt32 n_axis, UInt32[] axislist, Int32[] pos, float start_vel, float steady_vel, float end_vel, float acc, float dec, UInt32 sine);
        //********************************************************************************************************************************************************************
        /**
        * @brief ֹͣ����ֱ�ߵ�λ�˶�����չ������������滮��ʽ��
        * @param card_no��	�����Ŀ���
        *		 stop_dec��	����ֹͣ���ٶȣ����Ϊ������Ĭ�ϼ��ٶ�ֹͣ.	
        * @return �ɹ�����0.
        * @remark ��SLDM_PTPn_Plus ���ʹ��
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_PTPn_Stop_Plus(UInt32 card_no, float stop_dec);
		/**********************************************************************************
		* @End �����˶�
		***********************************************************************************/


		/**********************************************************************************
		* @Begin Բ���˶�
		***********************************************************************************/

		//********************************************************************************************************************************************************************
		/**
		* @brief ��άԲ���˶���Բ�ģ�
		* @param card_no��	�����Ŀ���
		*		 axislist��	��ά�������	
		*		 center_pos����άԲ��λ�����飬��λ���������		
		*		 end_pos��	��ά�յ�λ�ã���λ���������
		*		 ccw_dir��	Բ������0-��ʱ�룬1-˳ʱ��
		*		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 end_vel��	�յ��ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 dec��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		* @return �ɹ�����0.
		* @remark 
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Arc_2D(UInt32 card_no,  UInt32[] axislist,  float[] center_pos,  Int32[] end_pos, UInt32 ccw_dir, float start_vel, float steady_vel, float end_vel, float acc, float dec);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��չ��άԲ���˶���Բ�ģ�
		* @param card_no��	�����Ŀ���
		*		 axislist��	��ά�������	
		*		 center_pos����άԲ��λ�����飬��λ���������		
		*		 end_pos��	��ά�յ�λ�ã���λ���������
		*		 circle��	Ȧ������λ��Ȧ��0��һ��Բ��		
		*		 oft_pos��	���������������ȣ���λ���������
		*		 ccw_dir��	Բ������0-��ʱ�룬1-˳ʱ��
		*		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 end_vel��	�յ��ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 dec��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		* @return �ɹ�����0.
		* @remark 
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDMpi_Arc_2DEx(uint card_no, UInt32[] axislist, float[] center_pos, Int32[] end_pos, int circle, int oft_pos, uint ccw_dir, float start_vel, float steady_vel, float end_vel, float acc, float dec);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��άԲ���˶����뾶��
		* @param card_no��	�����Ŀ���
		*		 axislist��	��ά�������			
		*		 end_pos��	��ά�յ�λ�ã���λ���������
		*		 arc_Radius��Բ���뾶����λ���������
		*		 ccw_dir��	Բ������0-��ʱ�룬1-˳ʱ��
		*		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 end_vel��	�յ��ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 dec��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		* @return �ɹ�����0.
		* @remark 
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Arc_Radius(UInt32 card_no, UInt32[] axislist, Int32[] end_pos, float arc_Radius, uint ccw_dir, float start_vel, float steady_vel, float end_vel, float acc, float dec);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���������άԲ���岹�˶�
		* @param card_no��	�����Ŀ���	
		*		 axislist��	����б�
		*		 mid_pos��	�м�λ�����飬��λ������
		*		 target_pos��Ŀ��λ�����飬��λ������
		*		 start_vel����ʼ�ٶ�
		*		 steady_vel������ٶ�
		*		 end_vel��	�յ��ٶ�
		*		 acc��		���ٶ�
		*		 dec��		���ٶ�
		* @return �ɹ�����0.
		* @remark 
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Arc_3Points(UInt32 card_no, UInt32[] axislist, float[] mid_pos, Int32[] target_pos, float start_vel, float steady_vel, float end_vel, float acc, float dec);


		//********************************************************************************************************************************************************************
		/**
		* @brief ��άԲ���˶�ֹͣ
		* @param card_no��	�����Ŀ���
		*		 stop_dec��	����ֹͣ���ٶȣ����Ϊ������Ĭ�ϼ��ٶ�ֹͣ.			
		* @return �ɹ�����0.
		* @remark 
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Arc_Stop(UInt32 card_no, float stop_dec);


		/**********************************************************************************
		* @End Բ���˶�
		***********************************************************************************/


		/**********************************************************************************
		* @Begin �߼��˶�����
		***********************************************************************************/

		//********************************************************************************************************************************************************************
		/**
		* @brief ����ͣ������
		* @param card_no��	�����Ŀ���	
		*		 axis��		��ţ�0-3��
		*		 mid_pos��	�м��λ�ã���һ�� move �յ�λ��,��λ��pulse
		*		 target_pos���ڶ��� move �յ�λ��,��λ��pulse
		*		 start_vel����һ�� move ��ʼ�ٶ� 
		*		 steady_vel����һ�� move ����ٶ�
		*		 stop_vel��	��һ�� move ֹͣ�ٶ�
		*		 delay_ms��	��һ�׶���ɺ��ӳ�ʱ�䣨��λ�����룩
		*		 steady_vel2���ڶ��� move ����ٶ�
		*		 end_vel��	�ڶ��� move ֹͣ�ٶ�
		*		 acc_ms��	����ʱ��(��λ��ms)
		*		 dec_ms��	����ʱ��(��λ��ms)
		*		 posi_mode���˶�ģʽ��0�����ģʽ��1������ģʽ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Pmove_Extern(UInt32 card_no, UInt32 axis, int mid_pos, int target_pos, float start_vel, float steady_vel, float stop_vel,
								   uint delay_ms, float steady_vel2, float end_vel, uint acc_ms, uint dec_ms, UInt32 posi_mode);



		//********************************************************************************************************************************************************************
        /**
        * @brief ���Ÿ��湦��
        * @param card_no��	�����Ŀ���	
        *		 axis��		��������ţ�ȡֵ��Χ��0-3
        *		 enable��	ʹ��״̬��0����ֹ��1��ʹ��
        *		 master_axis������������ţ�ȡֵ��Χ��0-3
        *		 ratio��	���汶��
        *		 src��		λ��Դ 0-����λ�� 1-������λ��
		*       delay:		��������ʱ�����˶���ʱʱ�䣬��λ��ms 0-����ʱ ȡֵ��Χ��0-1000
        * @return �ɹ�����0.
        * @remark 
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Set_Gear_Follow(UInt32 card_no, UInt32 axis, UInt32 enable, UInt32 master_axis, float ratio, UInt32 src, UInt32 delay);
		/**********************************************************************************
		* @End �߼��˶�����
		***********************************************************************************/

		/**********************************************************************************
		* @Begin �������˶�
		***********************************************************************************/



		//********************************************************************************************************************************************************************
		/**
		* @brief ����ֱ�������˶�ʹ��
		* @param card_no��	�����Ŀ���
		*		 enable��	0-���ܣ�1-ʹ��	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Buff_Enable(UInt32 card_no, UInt32 enable);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��������ֱ�������˶�
		* @param card_no��	�����Ŀ���
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Start_Buff_Move(UInt32 card_no);
		//********************************************************************************************************************************************************************
		/**
		* @brief д�뻺����ֱ���˶�����
		* @param card_no��	�����Ŀ���
		*		 n_axis��	�˶�����������4�ᣩ	
		*		 p_axis��	�������	
		*		 pos��		����Ŀ��λ�����飬��λ pulse����Χ-2 31 ~2 31
		*		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000		
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 end_vel��	�յ��ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000	
		*		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 dec��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 sine��		�������ߣ�0-T�ͣ�1-S��
			
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Add_Buff_Segment(UInt32 card_no, UInt32 n_axis, UInt32[] axislist, Int32[] pos, float start_vel, float steady_vel, float end_vel, float acc, float dec, UInt32 sine);

		//********************************************************************************************************************************************************************
		/**
		* @brief �õ������˶���ǰ�������˶�����
		* @param card_no��	�����Ŀ���
		*		 p��		���������˶���ǰ�˶�����ֵ	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Buff_Move_Curent_P(UInt32 card_no, ref UInt32 p);
		//********************************************************************************************************************************************************************
		/**
		* @brief �õ������˶���ǰ���˶�����
		* @param card_no��	�����Ŀ���
		*		 p��		���������˶���ǰ�˶��ܶ���ֵ	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Buff_Move_Total_P(UInt32 card_no, ref UInt32 p);
		//********************************************************************************************************************************************************************
		/**
		* @brief �õ������˶���ǰ������д�����
		* @param card_no��	�����Ŀ���
		*		 p��		���ص�ǰ������д�����ֵ	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Buff_Segment_P(UInt32 card_no, ref UInt32 p);
		//********************************************************************************************************************************************************************
		/**
		* @brief �õ������˶���ǰblock������ʣ�����
		* @param card_no��	�����Ŀ���
		*		 space��		���ص�ǰblock��������ʣ�����	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Buff_Block_Space(UInt32 card_no, ref UInt32 space);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��λ�����˶���ǰblock������ָ��
		* @param card_no��	�����Ŀ���	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_ReSet_Buff_Segment_P(UInt32 card_no);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���õ�ǰ�˶�������ָ��λ��
		* @param card_no��	�����Ŀ���
		*		 run_buffer���������ţ�0-1	
		*		 curent_p��	�˶�������ָ��λ��	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Buff_Move_Curent_P(UInt32 card_no, UInt32 run_buffer, UInt32 curent_p);
		//********************************************************************************************************************************************************************
		/**
		* @brief �����������˶�����ֹͣ
		* @param card_no��	�����Ŀ���
		*		 stop_dec��	����ֹͣ���ٶȣ����Ϊ������Ĭ�ϼ��ٶ�ֹͣ.	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Stop_Buff_Move(UInt32 card_no, float stop_dec);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���û��������������˶�
		* @param card_no��	�����Ŀ���
		*		 one_step��	0-�����˶���1-�����˶�	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Buff_Move_Single_Step(UInt32 card_no, UInt32 one_step);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��λ�����˶�����
		* @param card_no��	�����Ŀ���
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Reset_Buff_Move(UInt32 card_no);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�����˶���������״̬
		* @param card_no��	�����Ŀ���
		*		 running��	�������˶�״̬ 0-ֹͣ��1-�������С�	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Running_BuffMove(UInt32 card_no, ref UInt32 running);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���������˶�ѭ������
		* @param card_no��	�����Ŀ���
		*		 loop��		ѭ��������0-����ѭ����	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Buff_Loop(UInt32 card_no, UInt32 loop);
		//********************************************************************************************************************************************************************
		/**
		* @brief д�뻺��������˶�����
		* @param card_no��	�����Ŀ���
		*		 n_axis��	�˶�����������4�ᣩ	
		*		 p_axis��	�������	
		*		 pos��		����Ŀ��λ�����飬��λ pulse����Χ-2 31 ~2 31
		*		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000		
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 end_vel��	�յ��ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000	
		*		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 dec��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 sine��		�������ߣ�0-T�ͣ�1-S��
		*		 out_bit��	�˶����յ����DOλ, ȡֵ��Χ��0-���DOλ��-1Ϊ��DO����	
		*		 out_data��	�˶����յ����DOֵ��ȡֵ��Χ��0-1
		*	     type��		�˶����� 0-ֱ�ߣ�1-Բ��
		*	     center_pos����άԲ��λ��
		*	     ccw_dir��	Բ������0-��ʱ�룬1-˳ʱ��
		*		 delaytime���յ���ͣʱ�䣬��λ��ms��0Ϊ����ʱ		
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Add_Mix_Segment(UInt32 card_no, UInt32 n_axis, UInt32[] axislist, Int32[] pos, float start_vel, float steady_vel, float end_vel, float acc, float dec, UInt32 sine, UInt32 type, float[] center_pos, UInt32 ccw_dir);
		//********************************************************************************************************************************************************************
		/**
		* @brief д�뻺��������˶����ݣ��Զ��Ӽ��٣�
		* @param card_no��	�����Ŀ���
		*		 n_axis��	�˶�����������4�ᣩ	
		*		 p_axis��	�������	
		*		 pos��		����Ŀ��λ�����飬��λ pulse����Χ-2 31 ~2 31	
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 acc��		Ŀ���(��)�ٶȣ���λ��pulse /(ms*ms) ��ȡֵ��Χ��0.001~8000.000
		*		 sine��		�������ߣ�0-T�ͣ�1-S��
		*		 out_bit��	�˶����յ����DOλ, ȡֵ��Χ��0-���DOλ��-1Ϊ��DO����	
		*		 out_data��	�˶����յ����DOֵ��ȡֵ��Χ��0-1
		*	     type��		�˶����� 0-ֱ�ߣ�1-Բ��
		*	     center_pos����άԲ��λ��
		*	     ccw_dir��	Բ������0-��ʱ�룬1-˳ʱ��
		*		 delaytime���յ���ͣʱ�䣬��λ��ms��0Ϊ����ʱ		
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Add_Mix_Seg(UInt32 card_no, UInt32 n_axis, UInt32[] axislist, Int32[] pos, float steady_vel, float acc, UInt32 sine, UInt32 type, float[] center_pos, UInt32 ccw_dir);
		//********************************************************************************************************************************************************************
		/**
		* @brief �����岹�ȴ� IO ����
		* @param card_no��	�����Ŀ���	
		*		 in_bit��	����ںţ�ȡֵ��Χ��0~15
		*		 on_off��	��ͨ״̬��0������ͨ��1����ͨ
		*		 delaytime����ʱʱ�䣬��λ��ms
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Wait_Input(UInt32 card_no, UInt32 in_bit, UInt32 on_off, UInt32 delaytime);
		//********************************************************************************************************************************************************************
		/**
		* @brief �����岹������ڹ켣����� IO �ͺ����������ִ�У�
		* @param card_no��	�����Ŀ���	
		*		 out_bit��	����ںţ�ȡֵ��Χ��0~15
		*		 on_off��	��ͨ״̬��0������ͨ��1����ͨ
		*		 delay_value���ͺ�ֵ����λ��ms���ͺ�ʱ��ģʽ���� pulse���ͺ����ģʽ��
		*		 delay_mode���ͺ�ģʽ��0���ͺ�ʱ�䣬1���ͺ����
		*		 reverse_time����ƽ��������ʱ��תʱ�䣬��λ��ms
		* @return �ɹ�����0.
		* @remark ���õ� IO ���������ڸ�ָ�����һ���켣��������
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Delay_Outbit_To_Start(UInt32 card_no, UInt32 out_bit, UInt32 on_off, UInt32 delay_value, UInt32 delay_mode, UInt32 reverse_time);
		//********************************************************************************************************************************************************************
		/**
		* @brief �����岹������ڹ켣���յ� IO �ͺ����
		* @param card_no��	�����Ŀ���	
		*		 out_bit��	����ںţ�ȡֵ��Χ��0~15
		*		 on_off��	��ͨ״̬��0������ͨ��1����ͨ
		*		 delaytime���ͺ�ʱ��ֵ����λ��ms
		*		 reverse_time����ƽ��������ʱ��תʱ�䣬��λ��ms
		* @return �ɹ�����0.
		* @remark ���õ� IO ���������ڸ�ָ�����һ���켣��������
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Delay_Outbit_To_Stop(UInt32 card_no, UInt32 out_bit, UInt32 on_off, UInt32 delay_time, UInt32 reverse_time);
		//********************************************************************************************************************************************************************
		/**
		* @brief �����岹������ڹ켣���յ� IO ��ǰ���������ִ�У�
		* @param card_no��	�����Ŀ���	
		*		 out_bit��	����ںţ�ȡֵ��Χ��0~15
		*		 on_off��	��ͨ״̬��0������ͨ��1����ͨ
		*		 ahead_value����ǰֵ����λ��ms����ǰʱ��ģʽ���� pulse����ǰ����ģʽ��
		*		 ahead_mode����ǰģʽ��0����ǰʱ�䣬1����ǰ����
		*		 reverse_time����ƽ��������ʱ��תʱ�䣬��λ��ms
		* @return �ɹ�����0.
		* @remark ���õ� IO ���������ڸ�ָ�����һ���켣��������
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Ahead_Outbit_To_Stop(UInt32 card_no, UInt32 out_bit, UInt32 on_off, UInt32 ahead_value, UInt32 ahead_mode, UInt32 reverse_time);
		//********************************************************************************************************************************************************************
		/**
		* @brief �������δִ����� IO ����
		* @param card_no��	�����Ŀ���	
		*		 io_bit��	IO�ں�
		* @return �ɹ�����0.
		* @remark 
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Clear_Io_Action(UInt32 card_no, UInt32 io_bit);
		//********************************************************************************************************************************************************************
		/**
		* @brief �����岹����ͣ��ʱָ��
		* @param card_no��	�����Ŀ���	
		*		 delaytime: �յ���ͣʱ�䣬��λ��ms��0Ϊ������ʱ	
		* @return �ɹ�����0.
		* @remark 
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_delay(UInt32 card_no, int delaytime);

		//********************************************************************************************************************************************************************
		/**
		* @brief ���û������˶���λ������ʹ��
		* @param card_no��	�����Ŀ���
		*		 enable��	0-���ܣ�1-ʹ��	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Move_ListEn(UInt32 card_no, UInt32 en);

		//********************************************************************************************************************************************************************
		/**
		* @brief ��ջ������˶���λ������
		* @param 
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Move_ListClear(UInt32 card_no);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�������˶���λ������ָ������
		* @param space��	����PC����������ָ��ȴ����أ�����

		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Buff_Move_ListSpace(UInt32 card_no, ref UInt32 space);

		/**********************************************************************************
		* @End �������˶�
		***********************************************************************************/

		/**********************************************************************************
		* @Begin IO����
		***********************************************************************************/

		//********************************************************************************************************************************************************************
		/**
		* @brief ��λ�������DOλ��״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	���λ�����ţ���Χ0~63
		*		 data��		IO�����״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_OutBit(UInt32 card_no, UInt32 addr, UInt32 index, UInt32 data);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��λ��ȡIO�����״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	���λ�����ţ���Χ0~63
		*		 data��		IO�����״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_OutBit(UInt32 card_no, UInt32 addr, UInt32 index, ref UInt32 data);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��λ��ȡIO�����״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	����λ�����ţ���Χ0~63
		*		 data��		IO�����״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_InBit(UInt32 card_no, UInt32 addr, UInt32 index, ref UInt32 data);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ֽ��������DOλ��״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	���λ�����ţ���Χ0~7
		*		 data��		IO���ֽ������״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_OutByte(UInt32 card_no, UInt32 addr, UInt32 index, UInt32 data);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ֽڶ�ȡ��վ��IO����״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	DI�����ţ���Χ��0~7
		*		 data��		IO�����״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_InByte(UInt32 card_no, UInt32 addr, UInt32 index, ref UInt32 data);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ֽڶ�ȡIO�����״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	���λ�����ţ���Χ0~7
		*		 data��		IO�����״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_OutByte(UInt32 card_no, UInt32 addr, UInt32 index, ref UInt32 data);

		//********************************************************************************************************************************************************************
		/**
		* @brief �����������DOλ��״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	���λ�����ţ���Χ0~3
		*		 data��		IO���������״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_OutWord(UInt32 card_no, UInt32 addr, UInt32 index, UInt32 data);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��˫���������DOλ��״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	���λ�����ţ���Χ0~1
		*		 data��		IO��˫�������״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_OutDWord(UInt32 card_no, UInt32 addr, UInt32 index, UInt32 data);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ֶ�ȡIO�����״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	���λ�����ţ���Χ0~3
		*		 data��		IO�����״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Get_OutWord(UInt32 card_no, UInt32 addr, UInt32 index, ref UInt32 data);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��˫�ֶ�ȡIO�����״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	���λ�����ţ���Χ0~1
		*		 data��		IO�����״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_OutDWord(UInt32 card_no, UInt32 addr, UInt32 index, ref UInt32 data);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ֶ�ȡ��վ��IO����״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	DI�����ţ���Χ��0~3
		*		 data��		IO�����״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_InWord(UInt32 card_no, UInt32 addr, UInt32 index, ref UInt32 data);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��˫�ֶ�ȡ��վ��IO����״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	DI�����ţ���Χ��0~1
		*		 data��		IO�����״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_InDWord(UInt32 card_no, UInt32 addr, UInt32 index, ref UInt32 data);

		//********************************************************************************************************************************************************************
		/**
		* @brief ע����Ӧ�����źŵĻص�����(IO�жϹ���)
		* @param card_no��	�����Ŀ���
		*		 fn��		�ص�����ָ��
		*		 addr��		�ӿ��ţ�����Ϊ0
		*		 in_bit��	DI�����ֽڵ�λ����
		*		 edge��		�źű��أ�0-�½��أ�1-������
		* @return �ɹ�����0.
		* @remark
		*/
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Register_Callback(UInt32 card_no, sldmv.fn cbEvent, UInt32 addr, UInt32 in_bit, UInt32 edge);
		//********************************************************************************************************************************************************************
        /**
        * @brief ȡ����Ӧ�����źŵĻص�����
        * @param card_no��	�����Ŀ���
        *		 addr��		�ӿ��ţ�����Ϊ0
        *		 in_bit��	DI�����ֽڵ�λ����
        *		 edge��		�źű��أ�0-�½��أ�1-������
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Unregister_Callback(UInt32 card_no, UInt32 addr, UInt32 in_bit, UInt32 edge);

		//********************************************************************************************************************************************************************
		/**
		* @brief ��λ����IO �����ʱ��ת
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	���λ�����ţ���Χ0~63
		*		 data��		IO�����״̬��0-����ͨ��1-��ͨ
		*		 reverse_time����ת��ʱʱ��(��λ��ms)��0-����ת,ȡֵ��Χ(0-42949672)ms
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Reverse_OutBit(UInt32 card_no, UInt32 addr, UInt32 index, UInt32 data, UInt32 reverse_time);
        //********************************************************************************************************************************************************************
        /**
        * @brief ��λ����IO ��ʱ�����ʱ��ת
        * @param card_no��	�����Ŀ���
        *		 addr��		�ӿ��ţ�����Ϊ0	
        *		 index��	���λ�����ţ���Χ0~63
        *		 data��		IO�����״̬��0-����ͨ��1-��ͨ
        *		 delay_time����ʱ���ʱ��(��λ��ms)��0-����ʱ
        *		 reverse_time����ת��ʱʱ��(��λ��ms)��0-����ת
        * @return �ɹ�����0.//
        * @remark
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Toggle_OutBit(UInt32 card_no, UInt32 addr, UInt32 index, UInt32 data, UInt32 delay_time, UInt32 reverse_time);


		/**********************************************************************************
		* @End IO����
		***********************************************************************************/






		/********************************************************************************
		* @Begin λ�ñȽ�
		*******************************************************************************/

		//********************************************************************************************************************************************************************
		/**
		* @brief λ�ñȽ�ʹ��
		* @param card_no��	�����Ŀ���
		*		 fifo��		λ�ñȽ���ѡ��(0-1)		
		*		 en��		ʹ��,0-��ʹ�ܣ�1-ʹ��	
		* @return �ɹ�����0.
		* @remark 
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Cmpr_Enable(UInt32 card_no, UInt32 fifo, UInt32 en);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ������λ�ñȽ�ʹ��״̬
		* @param card_no��	�����Ŀ���
		*		 fifo��		λ�ñȽ���ѡ��(0-1)	
		*		 en��		λ�ñȽ�ʹ��״̬��0-��ʹ�ܣ�1-ʹ��
		* @return �ɹ�����0.
		* @remark 
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Cmpr_Enable(UInt32 card_no, UInt32 fifo, ref UInt32 en);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���λ�ñȽ�����
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��	
		*		 cmpr_pos��	�Ƚ�λ��
		*		 fifo��		λ�ñȽ����ţ���Ӧ���DO��λ ��0-1��
		*		 width��	λ�ñȽ���������ȣ���λ10us
		*		 out_level���Ƚϳɹ�ʱDO�����״̬��0-����ͨ��1-��ͨ
		*		 src��		λ�ñȽ�λ��Դ��0-����λ�ã�1-������λ�á�
		* @return �ɹ�����0.
		* @remark 
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Cmpr_Add_Point(UInt32 card_no, UInt32 axis, int cmpr_pos, UInt32 fifo, UInt32 width, UInt32 out_level, UInt32 src);
		//********************************************************************************************************************************************************************
		/**
		* @brief �õ�λ�ñȽ�λ�û�����״̬
		* @param card_no��	�����Ŀ���
		*		 fifo��		λ�ñȽ���ѡ��(0-1)		
		*		 space��	������ʣ�������������256λ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Cmpr_Fifo_Space(UInt32 card_no, UInt32 fifo, ref UInt32 space);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���λ�ñȽ�λ�û����������Ƚ���ɸ���
		* @param card_no��	�����Ŀ���
		*		 fifo��		λ�ñȽ���ѡ��(0-1)	
		*		 fifo_data_en��	λ�ñȽϻ����������0-�������1-���	
		*		 complete_num_en��	λ�ñȽ���ɸ��������0-�������1-���
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Clear_Cmpr(UInt32 card_no, UInt32 fifo, UInt32 fifo_data_en, UInt32 complete_num_en);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ʼλ�ñȽ�
		* @param card_no��	�����Ŀ���
		*		 fifo��		λ�ñȽ���ѡ��(0-1)	
		*		 start��	��ʼ��0-ֹͣ��1-��ʼ	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Start_Cmpr(UInt32 card_no, UInt32 fifo, UInt32 start);
		//********************************************************************************************************************************************************************
		/**
		* @brief �õ�λ�ñȽ���ɸ���
		* @param card_no��	�����Ŀ���
		*		 fifo��		λ�ñȽ���ѡ��(0-1)		
		*		 num��		����λ�ñȽ���ɸ���
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Cmpr_Num(UInt32 card_no, UInt32 fifo, ref UInt32 num);
		//********************************************************************************************************************************************************************
		/**
		* @brief �����ȼ��λ�ñȽ�
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��0-4	
		*		 startPos��	��ʼλ�ñȽ�λ��
		*		 interval��	�Ƚ�λ�ü��
		*		 fifo��	λ�ñȽ����ţ���Ӧ���DO��λ ��0-1��
		*		 width��	λ�ñȽ���������ȣ���λ10us
		*		 out_level���Ƚϳɹ�ʱDO�����״̬��0-����ͨ��1-��ͨ
		*		 src��		λ�ñȽ�λ��Դ��0-����λ�ã�1-������λ�á�
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Compare_Linear(UInt32 card_no, UInt32 axis, int startPos, int interval, UInt32 fifo, UInt32 width, UInt32 out_level, UInt32 src);
		//********************************************************************************************************************************************************************
		/**
		* @brief ����λ�ñȽ�ģʽ
		* @param card_no��	�����Ŀ���
		*		 fifo��		λ�ñȽ���ѡ��(0-1)		
		*		 mod��		λ�ñȽ�ģʽ��0��һάλ�ñȽϣ�1���ȼ��λ�ñȽϣ�2����άλ�ñȽ�
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Cmpr_Mod(UInt32 card_no, UInt32 fifo, UInt32 mod);
        //********************************************************************************************************************************************************************
        /**
        * @brief ��άλ�ñȽ����λ�ñȽ�����
        * @param card_no��	�����Ŀ���
        *		 axislist��	��ά��ѡ���б�	
        *		 cmpr_pos��	��ά�Ƚ�λ���б�
        *		 max_err��	�Ƚ�λ�õ�λ�����������ȡֵ��Χ[0,512)����λ��pulse
        *		 threshould�������㷨��ֵ
        *		 fifo��		λ�ñȽ����ţ���Ӧ���DO��λ ��0-1��
        *		 width��	λ�ñȽ���������ȣ���λ10us
        *		 out_level���Ƚϳɹ�ʱDO�����״̬��0-����ͨ��1-��ͨ
        *		 src��		λ�ñȽ�λ��Դ��0-����λ�ã�1-������λ�á�
        * @return �ɹ�����0.
        * @remark 
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Cmpr_2D(UInt32 card_no,UInt32[] axislist, Int32[] cmpr_pos, UInt32 max_err, UInt32 threshould, UInt32 fifo, UInt32 width, UInt32 out_level, UInt32 src);
        //********************************************************************************************************************************************************************
        /**
        * @brief ��άλ�ñȽ����λ�ñȽ�����
        * @param card_no��	�����Ŀ���
        *		 axislist��	��ά��ѡ���б�	
        *		 cmpr_pos��	��ά�Ƚ�λ���б�
        *		 max_err��	�Ƚ�λ�õ�λ�����������ȡֵ��Χ[0,512)����λ��pulse
        *		 threshould�������㷨��ֵ
        *		 fifo��		λ�ñȽ����ţ���Ӧ���DO��λ ��0-1��
        *		 width��	λ�ñȽ���������ȣ���λ10us
        *		 out_level���Ƚϳɹ�ʱDO�����״̬��0-����ͨ��1-��ͨ
        *		 src��		λ�ñȽ�λ��Դ��0-����λ�ã�1-������λ�á�
        * @return �ɹ�����0.
        * @remark 
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Cmpr_3D(UInt32 card_no, UInt32[] axislist, Int32[] cmpr_pos, UInt32 max_err, UInt32 threshould, UInt32 fifo, UInt32 width, UInt32 out_level, UInt32 src);

		/**********************************************************************************
		* @End λ�ñȽ�
		***********************************************************************************/


		/**********************************************************************************
		* @Begin λ������
		***********************************************************************************/


		//********************************************************************************************************************************************************************
		/**
		* @brief ��ʼλ������
		* @param card_no��	�����Ŀ���
		*		 fifo��		λ��������ѡ��(0-1)
		*		 start��	1-��������,0-ֹͣ����
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Start_Latch(UInt32 card_no, UInt32 fifo, UInt32 start);
		//********************************************************************************************************************************************************************
		/**
		* @brief ����λ���������
		* @param card_no��	�����Ŀ���
		*		 fifo��		λ�����滺����ѡ�񣬣�λ�����滺����= DI�ںţ�0-1	
		*		 axis��	��ѡ�� 0-7
		*		 src��		λ������λ��Դѡ��0-ָ��λ�ã�1-������λ��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Latch_Para(UInt32 card_no, UInt32 fifo, UInt32 axis, UInt32 src);//,ushort trigger);
																										//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡλ����������
		* @param card_no��	�����Ŀ���
		*		 fifo��		λ�����滺����ѡ�񣬣�λ�����滺����= DI�ںţ�0-1	
		*		 pos��		����λ��
		*		 pos_delay����������ڵ�ƽ��Чʱ��
		*		 numofcapt��λ��������ɸ���
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Latch_Pos(UInt32 card_no, UInt32 fifo, [Out] int[] pos, [Out] UInt32[] pos_delay, ref UInt32 numofcapt);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡλ����������
		* @param card_no��	�����Ŀ���
		*		 fifo��		λ��������ѡ��(0-1)	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Clear_Latch_Fifo(UInt32 card_no, UInt32 fifo);

        /**
        * @brief ע��λ������ص�����
        * @param card_no��	�����Ŀ���
        *		 fn��		�ص�����	
        *		 fifo��		λ��������ѡ��(0-1)
        *		 hold_time����������ڵ�ƽ��Чʱ��
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Register_Latch_Callback(UInt32 card_no, sldmv.fn cbEvent, UInt32 fifo, UInt32 hold_time);
        /**
        * @brief ע��λ������ص�����
        * @param card_no��	�����Ŀ���
        *		 fifo��		λ��������ѡ��(0-1)
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Unregister_Latch_Callback(UInt32 card_no, UInt32 fifo);

		/**********************************************************************************
		* @End λ������
		***********************************************************************************/

		/**********************************************************************************
		* @Begin PT�˶�
		***********************************************************************************/

		//********************************************************************************************************************************************************************
		/**
		* @brief ��λPT�˶���PTģʽ��ʼ���˳�ʱ����
		* @param card_no��	�����Ŀ���	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PtInit(UInt32 card_no);
		//********************************************************************************************************************************************************************
		/**
		* @brief ����ָ����Ϊ PT �˶�ģʽ
		* @param card_no��	�����Ŀ���	
		*		 axis��		��ѡ��(0-3)	
		*		 mode��		PT_MODE_STATIC��̬ģʽ��PT_MODE_DYNAMIC ��̬ģʽ	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PrfPt(UInt32 card_no, UInt32 axis, UInt32 mode = 0);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ѯ PT �˶�ģʽָ�� FIFO ��ʣ��ռ�
		* @param card_no��	�����Ŀ���	
		*		 axis��		��ѡ��(0-3)	
		*		 pspace��	����Fifo�Ŷ�Ӧʣ��ռ䣬��̬ģʽʱ������ʣ��ռ�
		*		 fifo��		Fifo��(0-1)	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PtSpace(UInt32 card_no, UInt32 axis, ref UInt32 pspace, UInt32 fifo = 0);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���� PT �˶�
		* @param card_no��	�����Ŀ���	
		*		 axis��		��ѡ��(0-3)	
		*		 start��	1-������Ӧ���ᣬ0-ֹͣ��Ӧ����	
		*		 option��	λ�����ʾ����ʹ�õ� FIFO,Ĭ��Ϊ 0,��̬ģʽ�¸ò�����Ч.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PtStart(UInt32 card_no, UInt32 axis, UInt32 start, UInt32 option);
		//********************************************************************************************************************************************************************
		/**
		* @brief �� PT �˶�ģʽָ�� FIFO ��������
		* @param card_no��	�����Ŀ���	
		*		 axis��		���
		*		 pos��		λ��
		*		 time��		ʱ�䣬��λ����
		*		 type��		�˶����ͣ�0-��ͨ�Σ�1-���ٶΣ�2-���ٶ�
		*		 fifo��		Fifo��
		*		 move_delay���˶�������ֹͣ��ʱʱ��
		*		 out_bit��	�˶����������DOλ��-1�����
		*		 out_data��	�˶����������DOλ״̬��0-����ͨ��1-��ͨ
		*		 out_delay�����DOλ��ʱʱ��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PtData(UInt32 card_no, UInt32 axis, int pos, UInt32 time, UInt32 type, UInt32 fifo = 0, UInt32 move_delay = 0, int out_bit = -1, UInt32 out_data = 0, UInt32 out_delay = 0);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��� PT �˶�ģʽָ�� FIFO �е�����
		* @param card_no��	�����Ŀ���	
		*		 axis��		��ѡ��(0-3)		
		*		 fifo��		Fifo��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PtClear(UInt32 card_no, UInt32 axis, UInt32 fifo);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���� PT �˶�ģʽѭ��ִ�еĴ�������̬ģʽ�¸�ָ����Ч
		* @param card_no��	�����Ŀ���	
		*		 axis��		��ѡ��(0-3)		
		*		 loop��		ѭ��������0-����ѭ��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_SetPtLoop(UInt32 card_no, UInt32 axis, UInt32 loop);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ѯ PT �˶�ģʽѭ��ִ�еĴ�������̬ģʽ�¸�ָ����Ч
		* @param card_no��	�����Ŀ���	
		*		 axis��		��ѡ��(0-3)		
		*		 ploop��	����ѭ������
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_GetPtLoop(UInt32 card_no, UInt32 axis, ref UInt32 ploop);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���� PT �˶�ģʽ�Ļ�����(FIFO)��С
		* @param card_no��	�����Ŀ���	
		*		 memory��	���100	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_SetPtMemory(UInt32 card_no, UInt32 memory);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ PT �˶�ģʽ�Ļ�������С
		* @param card_no��	�����Ŀ���	
		*		 pmemory��	���ػ�������С
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_GetPtMemory(UInt32 card_no, ref UInt32 pmemory);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ PT �˶�ģʽ�Ļ������˶�ָ��
		* @param card_no��	�����Ŀ���	
		*		 axis��		��ѡ��(0-3)	
		*		 move_p��	���ػ������˶�ָ��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_GetPtMoveP(UInt32 card_no, UInt32 axis, ref UInt32 move_p);

		//********************************************************************************************************************************************************************
		/**
		* @brief ����PT�˶���λ������ʹ��
		* @param card_no��	�����Ŀ���
		*		 enable��	0-���ܣ�1-ʹ��	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Pt_ListEn(UInt32 card_no, UInt32 en);

		//********************************************************************************************************************************************************************
		/**
		* @brief ���PT�˶���λ������
		* @param card_no��	�����Ŀ���
				 axis��		���
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Pt_ListClear(UInt32 card_no, UInt32 axis);

		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡPT�˶���λ������ָ������
		* @param card_no��	�����Ŀ���
				 space��	����PC����������ָ��ȴ����أ�����
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Pt_ListSpace(UInt32 card_no, ref UInt32 space);



		/**********************************************************************************
		* @End PT�˶�
		***********************************************************************************/

		/**********************************************************************************
		* @Begin PWM����
		***********************************************************************************/


		//********************************************************************************************************************************************************************
		/**
		* @brief ����PWM����ʹ��
		* @param card_no��	�����Ŀ���	
		*		 pwm��		PWMģ���(0-1)
		*		 en��		PWMģ��ʹ�ܣ�1-ʹ�ܣ�0-��ֹ��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_PWM_Enable(UInt32 card_no, UInt32 pwm, UInt32 en);
		//********************************************************************************************************************************************************************
		/**
		* @brief ����PWM���ܿ�ʼ
		* @param card_no��	�����Ŀ���	
		*		 pwm��		PWMģ���(0-1)
		*		 start��	1-��ʼ��0-ֹͣ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PWM_Start(UInt32 card_no, UInt32 pwm, UInt32 start);
		//********************************************************************************************************************************************************************
		/**
		* @brief ����PWM���ܲ���
		* @param card_no��	�����Ŀ���	
		*		 pwm��		PWMģ���
		*		 duty��		PWMռ�ձ� 0-1
		*		 fre��		PWMƵ��
		*		 pol��		PWM����
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_PWM_Config(UInt32 card_no, UInt32 pwm, float duty, float fre, UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ����PWM����ʹ��
		* @param card_no��	�����Ŀ���	
		*		 pwm��		PWMģ���
		*		 duty��		����PWMռ�ձ�
		*		 fre��		����PWMƵ��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_PWM(UInt32 card_no, UInt32 pwm, ref float duty, ref float fre);

		//********************************************************************************************************************************************************************
		/**
		* @brief ��ʹ�ø���ģʽ�������岹�� PWM ������ã����PWM�Ѿ��򿪣�PWM ���Ƶ�ʼ�ռ�ձ������ı�
		* @param card_no��	�����Ŀ���	
		*		 pwm��		PWMģ��� 0-1
		*		 fDuty��	PWMռ�ձ� 0-1
		*		 fFre��		PWMƵ��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Set_PWM_Output(UInt32 card_no, UInt32 pwm, float fDuty, float fFre);
		//�� �ܣ����� PWM ����״̬��Ӧ��ռ�ձ�,����4����������ʹ�ã�����ģʽ0-4
		//********************************************************************************************************************************************************************
		/**
		* @brief ʹ�ø���ģʽ������ PWM ����״̬��Ӧ��ռ�ձ�
		* @param card_no��	�����Ŀ���	
		*		 pwm��		PWMģ���
		*		 fOnDuty��	PWM ��״̬��ռ�ձȣ�ȡֵ��Χ��0~1
		*		 fOffDuty��	PWM �ر�״̬��ռ�ձȣ�ȡֵ��Χ��0~1
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Set_PWM_Onoff_Duty(UInt32 card_no, UInt32 pwm, float fOnDuty, float fOffDuty);

		//********************************************************************************************************************************************************************
		/**
		* @brief ʹ�ø���ģʽ�������岹�� PWM �ٶȸ�������
		* @param card_no��	�����Ŀ���	
		*		 pwm��		PWMģ��ţ�ȡֵ��Χ��0~1
		*		 mode��		����ģʽ��
							0�������棬����״̬
							1�������棬����͵�ƽ
							2�������棬����ߵ�ƽ
							3�����棬ռ�ձ��Զ�����
							4�����棬Ƶ���Զ�����
		*		 maxVel��	��������ٶȣ���λ��pulse /ms
		*		 maxValue��	������ֵ��
							����ģʽΪ 3 ʱ��ռ�ձȣ�ȡֵ��Χ��0~1
							����ģʽΪ 4 ʱ��Ƶ�ʣ�ȡֵ��Χ��0~2MHz
		*		 outValue��	�̶����ֵ��
							����ģʽΪ 3 ʱ��Ƶ�ʣ�ȡֵ��Χ��0~2MHz
							����ģʽΪ 4 ʱ��ռ�ձȣ�ȡֵ��Χ��0~1
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Set_PWM_Follow_Speed(UInt32 card_no, UInt32 pwm, UInt32 mode, float maxVel, float maxValue, float outValue);

		//********************************************************************************************************************************************************************
		/**
		* @brief �����岹������ڹ켣����� PWM �ͺ����������ִ�У�
		* @param card_no��		�����Ŀ���	
		*		 pwm��			PWMģ��ţ�ȡֵ��Χ��0~1
		*		 on_off��		���״̬��0���رգ�1����
		*		 delay_value��	�ͺ�ֵ����λ��ms���ͺ�ʱ��ģʽ���� pulse���ͺ����ģʽ��
		*		 delay_mode��	�ͺ�ģʽ��0���ͺ�ʱ�䣬1���ͺ����
		*		 reverse_time��	�����������̶�ֵΪ 0
		* @return �ɹ�����0.
		* @remark ���õ� IO ���������ڸ�ָ�����һ���켣��������
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Delay_PWM_To_Start(UInt32 card_no, UInt32 pwm, UInt32 on_off, UInt32 delay_value, UInt32 delay_mode, float reverse_time);

		//********************************************************************************************************************************************************************
		/**
		* @brief �����岹������ڹ켣���յ� PWM ��ǰ���������ִ�У�
		* @param card_no��		�����Ŀ���	
		*		 pwm��			PWMģ��ţ�ȡֵ��Χ��0~1
		*		 on_off��		���״̬��0���رգ�1����
		*		 ahead_value��	��ǰֵ����λ��ms����ǰʱ��ģʽ���� pulse����ǰ����ģʽ��
		*		 ahead_mode��	��ǰģʽ��0����ǰʱ�䣬1����ǰ����
		*		 reverse_time��	�����������̶�ֵΪ 0
		* @return �ɹ�����0.
		* @remark ���õ� IO ���������ڸ�ָ�����һ���켣��������
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Ahead_PWM_To_Stop(UInt32 card_no, UInt32 pwm, UInt32 on_off, UInt32 ahead_value, UInt32 ahead_mode, float reverse_time);



		/**********************************************************************************
		* @End PWM����
		***********************************************************************************/


		/**********************************************************************************
		* @Begin ��������������
		***********************************************************************************/
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�������Ĳ�Ʒ�汾��
		* @param card_no��	�����Ŀ���
		*		 softver��	���������汾��
		*		 fpgaver��	����Ӳ���汾��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_SysVersion(UInt32 card_no, ref UInt32 softver, ref UInt32 fpgaver);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ��������ARM���к�
		* @param card_no��	�����Ŀ���
		*		 id��		���ؿ�������ARM���к�(12byte) 
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_ArmID(UInt32 card_no, ref UInt32 id);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�������Ĳ�Ʒ���к�
		* @param card_no��	�����Ŀ���
		*		 id��		���ؿ������Ĳ�Ʒ���к�(4byte)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_CardID(UInt32 card_no, ref UInt32 id);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�������Ĳ�Ʒ��Ϣ
		* @param card_no��	�����Ŀ���
		*		 card_info�����ؿ������Ĳ�Ʒ��Ϣ�ṹ��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_CardInfo(UInt32 card_no, ref CARD_INFO card_info);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ������IO��������
		* @param card_no��	�����Ŀ���
		*		 axis_num��	���ؿ�������(Ĭ��4)
		*		 di_num��	������������˿�����(Ĭ��16)
		*		 do_num��	������������˿�����(Ĭ��16)
		*		 ad_num��	����ģ��������˿�����(Ĭ��0)
		*		 da_num��	����ģ��������˿�����(Ĭ��0)
		*		 pwm_num��	����PWM�˿�����(Ĭ��2)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Card_IOResource(UInt32 card_no, ref UInt32 axis_num, ref UInt32 di_num, ref UInt32 do_num, ref UInt32 ad_num, ref UInt32 da_num, ref UInt32 pwm_num);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ������λ�ñȽ����湦��ģ����������
		* @param card_no��	�����Ŀ���
		*		 cmpr1_num��	����һάλ�ñȽ�������(Ĭ��2)
		*		 cmprline_num��	��������λ�ñȽ�������(Ĭ��2)
		*		 cmpr2_num��	���ض�άλ�ñȽ�������(Ĭ��0)
		*		 latch_num��	����λ������������(Ĭ��2)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Card_EXResource(UInt32 card_no, ref UInt32 cmpr1_num, ref UInt32 cmprline_num, ref UInt32 cmpr2_num, ref UInt32 latch_num);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ������ģʽ����
		* @param card_no��	�����Ŀ���
		*		 model��	���ؿ�����ģʽ
		*		 type��		���ؿ���������
		*		 period��	���ؿ������ŷ�����
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Card_Model(UInt32 card_no, ref UInt32 model, ref UInt32 type, ref UInt32 period);


		//********************************************************************************************************************************************************************
		/**
		* @brief �û���Ʒע����д��
		* @param card_no��	�����Ŀ���
		*		 reg_code��	�ͻ�ע����
		*		 reg_code_md5������д���������MD5�� ��16byte��
		* @return �ɹ�����0.
		* @remark (EEPROM��С��20*32bit)
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Write_Regcode(UInt32 card_no,  byte[] reg_code, ref byte reg_code_md5);
		//********************************************************************************************************************************************************************
		/**
		* @brief ����д���������MD5��
		* @param card_no��	�����Ŀ���
		*		 reg_code��	����д���������MD5�루16byte��
		* @return �ɹ�����0.
		* @remark (EEPROM��С��20*32bit)
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Read_Regcode(UInt32 card_no, ref byte reg_code);
		//********************************************************************************************************************************************************************
		/**
		* @brief EEPROM����д�� 
		* @param card_no��	�����Ŀ���
		*		 addr��		д���ַ,��Χ��0-20
		*		 num��		д�����0-20
		*		 pData��	д������,��Χ��32bit
		* @return �ɹ�����0.
		* @remark (EEPROM��С��20*32bit)
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_E2prom_Write(UInt32 card_no, UInt32 addr, UInt32 num, UInt32[] pData);
		//********************************************************************************************************************************************************************
		/**
		* @brief EEPROM���ݶ��� 
		* @param card_no��	�����Ŀ���
		*		 addr��		������ַ,��Χ��0-20
		*		 num��		��������0-20
		*		 pData��	��������,��Χ��32bit
		* @return �ɹ�����0.
		* @remark (EEPROM��С��20*32bit)
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_E2prom_Read(UInt32 card_no, UInt32 addr, UInt32 num, ref int pData);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��չEEPROM����д�� 
		* @param card_no��	�����Ŀ���
		*		 addr��		д���ַ,��Χ��0-20
		*		 num��		д�����0-20
		*		 pData��	д������,��Χ��32bit
		* @return �ɹ�����0.
		* @remark (EEPROM��С��20*32bit)
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_ExE2prom_Write(UInt32 card_no, UInt32 addr, UInt32 num, int[] pData);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��չEEPROM���ݶ��� 
		* @param card_no��	�����Ŀ���
		*		 addr��		������ַ,��Χ��0-20
		*		 num��		��������0-20
		*		 pData��	��������,��Χ��32bit
		* @return �ɹ�����0.
		* @remark (EEPROM��С��20*32bit)
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_ExE2prom_Read(UInt32 card_no, UInt32 addr, UInt32 num, ref int pData);

		//********************************************************************************************************************************************************************
		/**
		* @brief װ��ϵͳ�����ļ������ص������� 
		* @param card_no��	�����Ŀ���
		* @return �ɹ�����0.
		* @remark �����ļ���E450config.ini
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Load_ParaFile(UInt32 card_no);

		//********************************************************************************************************************************************************************
		/**
		* @brief ����ϵͳ�����ļ�
		* @param card_no��	�����Ŀ���
		* @return �ɹ�����0.
		* @remark �����ļ���E450config.ini
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int  SLDM_Save_ParaFile(UInt32 card_no);


		/**********************************************************************************
		* @End ��������������
		***********************************************************************************/

        /**********************************************************************************
        * @Begin ETHERCAT����
        ***********************************************************************************/


        //********************************************************************************************************************************************************************
        /**
        * @brief ����ethercat�����������������ͺ�
        * @param card_no��	�����Ŀ���
        *		 axisnum��	��������������
        *		 type��		�������������ͺ��б�����
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Set_Ecat_Axis(UInt32 card_no, UInt32 axis_num,UInt32[] type);

        //********************************************************************************************************************************************************************
        /**
        * @brief ethercat��������λ
        * @param card_no��	�����Ŀ���
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Ecat_Reset(UInt32 card_no);


        //********************************************************************************************************************************************************************
        /**
        * @brief ��ȡethercat������������״̬
        * @param card_no��	�����Ŀ���
        *		 cur_axisnum��		��ǰ���������
        *		 online_flag��		λ�����ʾ�������߱�־ 0-���� 1-����
        *		 link_ok��			���ʼ��������ɱ�־ 0-δ��� 1-���
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Get_Ecat_Status(UInt32 card_no, ref UInt32 cur_axisnum, ref UInt32 online_flag, ref UInt32 link_ok);

        //********************************************************************************************************************************************************************
        /**
        * @brief ��ȡethercat������������Z�ź�����λ��
        * @param card_no��	�����Ŀ���
        *		 axis��		���
        *		 pos��		���صĶ�Ӧ������Z�ź�����λ�ü���ֵ
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Get_Ecat_ZCap_pos(UInt32 card_no, UInt32 axis,ref int pos);

        //********************************************************************************************************************************************************************
        /**
        * @brief ��ȡethercat��������Ȩ��������
        * @param card_no��	�����Ŀ���
        *		 axisnum��	���ؿ�������Ȩ��������
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Get_Ecat_Release_AxisNum(UInt32 card_no,ref UInt32 axisnum);

        //********************************************************************************************************************************************************************
        /**
        * @brief ��ȡethercat��������չ������λ��
        * @param card_no��	�����Ŀ���
        *		 exenc_num����չ�������ţ���ethercat��������������Ż����ϵ���
        *		 pos��		���صĶ�Ӧ����������ֵ
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Get_EcatEx_Enc(UInt32 card_no, UInt32 exenc_num,ref int pos);


        /**********************************************************************************
        * @End ETHERCAT����
        ***********************************************************************************/

        /**********************************************************************************
        * @Begin ���ֹ���
        ***********************************************************************************/
        //********************************************************************************************************************************************************************
        /**
        * @brief ���������˶�����
        * @param card_no��	�����Ŀ���
        *		 axis_num��	���ֿ�������
        *		 axis_list��������ѡ��λ��Ӧ�������б�����
        *		 mult_list�����ֱ���ѡ��λ��Ӧ���Ʊ����б�����
        *		 dir_pol��	�����ԡ���0-����1-����	
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Set_HandWheel_Config(UInt32 card_no, UInt32 axis_num,UInt32[] axis_list,UInt32[] mult_list, UInt32 dir_pol);
        //********************************************************************************************************************************************************************
        /**
        * @brief ���������˶�����ٶȺͼ��ٶ�
        * @param card_no��	�����Ŀ���
        *		 max_vel��	����ٶȣ���λ��p/ms
        *		 max_acc��	�����ٶȣ���λ��p/(ms*ms)	
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Set_HandWheel_MaxVel(UInt32 card_no, UInt32 max_vel, UInt32 max_acc);
        //********************************************************************************************************************************************************************
        /**
        * @brief ���������˶�ʹ��
        * @param card_no��	�����Ŀ���
        *		 enable��	ʹ�ܣ�0-��ʹ�ܣ�1-ʹ��	
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Set_HandWheel_Enable(UInt32 card_no, UInt32 enable);
        //********************************************************************************************************************************************************************
        /**
        * @brief ��ȡ��������˿�״̬
        * @param card_no��	�����Ŀ���
        *		 di_status��XYZ45��X10X100�˿ڵ�ƽ״̬
        *					bit:
        *					0��X
        *					1��Y
        *					2��Z
        *					3��4
        *					4��5
        *					5��X10
        *					6��X100
        *					7��0
        *		 enc_data��	���ֱ���������ֵ

        * @return �ɹ�����0.
        * @remark �����ļ���E450config.ini
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Get_HandWheel_Status(UInt32 card_no,ref UInt32 di_status,ref int enc_data);
        /**********************************************************************************
        * @End ���ֹ���
        ***********************************************************************************/


		/**********************************************************************************
		* @Begin �������Ժ���
		***********************************************************************************/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Recbuf(UInt32 card_no, ref string recbuf, ref string recbuf_ID, ref string recbuf_EEP, ref string recbuf_SELF, ref string recbuf_ERR);
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Sendbuf(UInt32 card_no, ref string sendbuf);
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_commthread_debug(UInt32 card_no, short debug_mode, short debug_key);
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Test_function(UInt32 card_no, UInt32 para_num);//����UDP����
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_CommTime(ref float cur_time, ref float max_time);
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_CommTime_10000(ref float time);
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_udp_complete_num(ref int write_num, ref int read_num);
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Home_flag(UInt32 card_no, UInt32 axis, ref int flag);
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Cmpr_2D(UInt32 card_no, ref UInt32 axislist, ref int cmpr_pos, UInt32 max_err, UInt32 threshould, UInt32 fifo, UInt32 width, UInt32 out_level, UInt32 src);

		/**********************************************************************************
		* @End �������Ժ���
		***********************************************************************************/

		//********************************************************************************************************************************************************************
		/**
		* @brief ��λ����ת������
		* @param axis��		���.
		*		 PPR��		ÿת������
		*		 pitch��	�ݾ࣬��λms
		*		 unit_value��	��ת����λ���룬��λms
		*		 pulse_value��	ת���������������λ������
		* @return �ɹ�����0.
		* @remark �����ļ���E450config.ini
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int Unit_TO_Pulse(int axis, float PPR, float pitch, float unit_value, ref int pulse_value);

		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PTPn_Ex_Register(UInt32 id, UInt32 n_axis,  UInt32[] cardlist,  UInt32[] axislist);
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PTPn_Ex(UInt32 id,  int[] pos, float start_vel, float steady_vel, float end_vel, float acc, float dec, UInt32 sine, int dist_mode);
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PTPn_Ex_GetRunning(UInt32 id, ref UInt32 running);
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PTPn_Ex_Stop(UInt32 id, float stop_dec);

		[DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Add_Jump_Down(UInt32 card_no, Jump_Data  jump_data);
		[DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Add_Jump_Up(UInt32 card_no, Jump_Data  jump_data);
		[DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Add_Jump_Steady(UInt32 card_no, Jump_Data  jump_data);
		[DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Write_ToUart(UInt32 card_no, UInt32 uart_no, UInt32 num, byte[] data);

		[DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Read_FromUart(UInt32 card_no, UInt32 uart_no, ref UInt32 num, byte[] data);
		[DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Uart_Trans_Enable(UInt32 card_no, UInt32 uart_no, UInt32 en);
#else
		/***************************************************************************************************
		*			��������ֵ���京��
		***************************************************************************************************/
		/*���ݽṹ*/
		public static int SLDM_ERR_OK = 0;                 /*�޴���*/
		public static int SLDM_ERR_PMVAL = -1;             /*����ֵ����*/
		public static int SLDM_ERR_PULSEOVERFLOW = -2;             /*���巢�������*/
		public static int SLDM_ERR_PMID = -3;              /*����ID�����ڣ��޴˲���*/
		public static int SLDM_ERR_MCMAX = -4;             /*�����������ڣ�����ϵͳ֧�ֵ���������������*/
		public static int SLDM_ERR_CHMAX = -5;             /*ͨ���Ų����ڣ�����ϵͳ���ͨ����*/
		public static int SLDM_ERR_AXISMAX = -6;               /*��Ų����ڣ�����ϵͳ�������*/
		public static int SLDM_ERR_NOAUTH = -7;                /*����������Ȩ*/
		public static int SLDM_ERR_ADDROVERFLOW = -8;              /*������ַ���*/
		public static int SLDM_ERR_NOFLAG = -9;                /*û�д�״̬���־*/
		public static int SLDM_ERR_NONSTOPPED = -10;               /*�˶�û��ֹͣ*/
		public static int SLDM_ERR_MCNOFILE = -11;             /*�ļ��Ŵ�ʧ�ܡ��ļ��Ų����ڣ���SD�������ڡ�*/
		public static int SLDM_ERR_HOSTNOFILE = -12;               /*HOST���ļ�ʧ��*/
		public static int SLDM_ERR_AXISALM = -13;              /*���ŷ�����*/
		public static int SLDM_ERR_AXISPOT = -14;              /*������Ӳ��λ*/
		public static int SLDM_ERR_AXISNOT = -15;              /*�Ḻ��Ӳ��λ*/
		public static int SLDM_ERR_AXISPSL = -16;              /*����������λ*/
		public static int SLDM_ERR_AXISNSL = -17;              /*�Ḻ������λ*/
		public static int SLDM_ERR_AXISESTOP = -18;                /*Ӳ��ͣ*/
		public static int SLDM_ERR_AXISOT = -19;               /*��Ӳ��λ*/
		public static int SLDM_ERR_AXISSL = -20;               /*������λ*/
		public static int SLDM_ERR_PARANUM = -25;              /*����������������*/

		public static int SLDM_ERR_CURRENTPOS = -30;               /*����λ����岹λ��������*/
		public static int SLDM_ERR_ARCRADIUS = -32;                /*Բ���뾶������*/
		public static int SLDM_ERR_ENDPOS = -33;               /*�յ�λ�ô���*/
		public static int SLDM_ERR_INDEXMAX = -34;             /*���������Ŵ��󣬳������������*/
		public static int SLDM_ERR_ADDRMAX = -35;              /*������ַ�Ŵ��󣬳�������ַ��*/
		public static int SLDM_ERR_FUNCTIONEN = -36;               /*ģʽ����û��ʹ�ܻ��ʼ��*/
		public static int SLDM_ERR_BUFFENABLE = -37;               /*��������ֹ����*/
		public static int SLDM_ERR_BUFFMAX = -39;              /*������󻺳�������*/
		public static int SLDM_ERR_SPITIMEOVER = -40;              /*spiͨѶ��ʱ*/
		public static int SLDM_ERR_SPISYSTICKS = -41;              /*spi��������*/

		public static int PULSE_NUM_LESS_1 = -57;              /*�������С��1*/
		public static int PULSE_PERIOD_LESS_1 = -58;               /*��������С��1*/
		public static int OVERPPOS = -59;              /*����λ�����*/
		public static int OVERNPOS = -60;              /*����λ�����*/
		public static int PT_PLAN_OUT = -61;               /*PT�˶������������*/
		public static int HOMEING_MOVE = -62;              /*�����У�������λ����*/
		public static int BLOCK_EDGE_OUT = -63;                /*�������˶������������*/
		public static int BLOCK_EDGE_PTP1 = -64;               /*�������˶�ֱ�߲岹����*/
		public static int BLOCK_EDGE_ARC = -65;                /*�������˶�Բ���岹����*/
		public static int BLOCK_EDGE_RESTARTMOVE = -66;                /*�������˶�������������*/
		public static int BLOCK_ADD_POS = -67;             /*�������˶��ϳɾ���Ϊ0����*/

		public static int SLDM_ERR_OPEN = -90;             /*���ƿ���ʧ��*/
		public static int SLDM_ERR_OPENED = -91;               /*���ƿ��Ѿ���*/
		public static int SLDM_ERR_FREE = -92;             /*����ֱ���˳�*/
		public static int SLDM_ERR_IO_OVERTIME = -93;              /*������IOͨѶ��ʱ*/
		public static int SLDM_ERR_PC_IPADDR = -99;                /*PC IP��ַ����,��δ����*/

		public static int SLDM_ERR_FPGA_CMDBUFFFULL = -100;                /*FPGAָ�������*/
		public static int SLDM_ERR_COM_ADDR = -101;                /*��HOSTͨѶ���豸��ַ����*/
		public static int SLDM_ERR_COM_CHECKSUM = -102;                /*��HOSTͨѶ��У��ʹ���*/
		public static int SLDM_ERR_COM_INVCMD = -103;              /*��HOSTͨѶ������ID����*/
		public static int SLDM_ERR_SOCKET = -104;              /*HOST���У�SOCKET��ʼ��ʧ��*/
		public static int SLDM_ERR_SHM = -105;             /*HOST���У�SHM��ʼ��ʧ��*/
		public static int SLDM_ERR_PIPE = -106;                /*HOST���У�PIPE��ʼ��ʧ��*/
		public static int SLDM_ERR_NOLIBINITD = -107;              /*HOST��û�г�ʼ��*/
		public static int SLDM_ERR_NOMCOPEN = -108;                /*������δ��,��������ر�ʧ��*/
		public static int SLDM_ERR_MCOPEND = -109;             /*HOST���У��������Ѵ�*/
		public static int SLDM_ERR_MC_NONCONNECT = -110;               /*HOST�������ͨѶ��ʱ��δ����*/
		public static int SLDM_ERR_MC_CONNECTING = -111;               /*HOST���������������*/
		public static int SLDM_ERR_THREAD = -112;              /*HOST���У��̳߳�ʼ��ʧ��*/
		public static int SLDM_ERR_BUFFIDX = -113;             /*������������Ŵ���*/
		public static int SLDM_ERR_REFMESSAGE = -114;              /*�յ�������*/
		public static int SLDM_ERR_PREBUFFFULL = -115;             /*��׼������Ԥ��������*/
        public static int SLDM_ERR_BUFFFULL = -116;			/*��׼����黺������*/

        public static int SLDM_ERR_FB_TIMEOUT = -121;				/*�ŷ��ֳ����߳�ʱ*/
        public static int SLDM_ERR_FB_NCYCWNG = -122;				/*�ŷ������з���������ִ�б���*/
        public static int SLDM_ERR_FB_CCYCERR = -123;				/*�ŷ������з���������ִ�д���*/

		public static int SLDM_ERR_SERVICE_STOP = -230;                /*�������������ֹͣ*/
		public static int SLDM_ERR_UPDATE = -255;              /*�ڲ�ʹ�ã���������*/

		//@Begin ���ش���ID�ĺ������� ����
		public static int SLDM_OPEN_CODE = 0X01;   //1
		public static int SLDM_CLOSE_CODE = 0X02;  //2
		public static int SLDM_E2PROM_WRITE_CODE = 0X06;   //6
		public static int SLDM_E2PROM_READ_CODE = 0X07;    //7
		public static int SLDM_WRITE_REGCODE_CODE = 0X08;  //8
		public static int SLDM_READ_REGCODE_CODE = 0X09;   //9
		public static int SLDM_EXE2PROM_WRITE_CODE = 0X0A; //10
		public static int SLDM_EXE2PROM_READ_CODE = 0X0B;  //11
        public static int SLDM_FLASH_WRITE_CODE   =	0X0C;	//12
        public static int SLDM_ERASE_NEWAPP = 0X0D;	//13
		public static int SLDM_SET_COMM_PERIOD = 0X0E; //14
		public static int SLDM_SET_DEBUG_MODE_CODE = 0X0F; //15

		public static int SLDM_SET_DIR_POL_CODE = 0X10;    //16
		public static int SLDM_SET_ENC_POL_CODE = 0X11;    //17
		public static int SLDM_SET_CPOS_CODE = 0X12;   //18
        public static int SLDM_SET_ENC_ENABLE = 0X13;	//19
		public static int SLDM_SET_ENC_CODE = 0X14;    //20
		public static int SLDM_SET_SERVOON_CODE = 0X1B;    //27
		public static int SLDM_SET_RSTALM_CODE = 0X1D; //29

		public static int SLDM_SET_PLIMIT_CONFIG_CODE = 0X20;  //32
		public static int SLDM_SET_NLIMIT_CONFIG_CODE = 0X21;  //33
		public static int SLDM_SET_ORG_CONFIG_CODE = 0X22; //34
		public static int SLDM_SET_SERVOALM_CONFIG_CODE = 0X23;    //35
		public static int SLDM_SET_SOFT_LIMIT_CODE = 0X24; //36
		public static int SLDM_RESET_CODE = 0X2E;  //46
		public static int SLDM_CLEAR_ALARM_HISTORY_CODE = 0X30;    //48
		public static int SLDM_SET_ENCZ_POL_CODE = 0X32;   //50
		public static int SLDM_SET_EMG_CONFIG_CODE = 0X33; //51
		public static int SLDM_SET_PULSE_MODE_CODE = 0X35; //53
		public static int SLDM_SET_PULSE_POL_CODE = 0X36;  //54
		public static int SLDM_SET_ENC_FILTER_CODE = 0X37; //55
		
		public static int SLDM_SET_SPEC_INPUT_FILTER_CODE = 0X39;  //57
		public static int SLDM_SET_AXIS_INPUT_FILTER_CODE = 0X3A;  //58

        public static int SLDM_PTPN_GROUP	=	0x3E;	//62
        public static int SLDM_PTPN_STOP_GROUP = 0x3F;	//63

		public static int SLDM_SET_HOME_PARA_CODE = 0X50;  //80
		public static int SLDM_JOGA_CODE = 0X51;   //81
		public static int SLDM_PTP1_CODE = 0X52;   //82
		public static int SLDM_PTP1R_CODE = 0X53;  //83
		public static int SLDM_JOGP_CODE = 0X54;   //84
		public static int SLDM_JOGM_CODE = 0X55;   //85
		public static int SLDM_SET_HOME_OFT_CODE = 0X56;   //86
		public static int SLDM_STOP_CODE = 0X58;   //88
		public static int SLDM_ESTOP_CODE = 0X59;  //89
		public static int SLDM_CHANGE_POS_CODE = 0X5A; //90
		public static int SLDM_CHANGE_VEL_CODE = 0X5B; //91
		public static int SLDM_PTPN_CODE = 0X5C;   //92
		public static int SLDM_PTPN_STOP_CODE = 0X5D;  //93
		public static int SLDM_PMOVE_EXTERN_CODE = 0X5E;   //94
		public static int SLDM_HOME_MOVE_CODE = 0X5F;  //95

		public static int SLDM_SET_BUFF_ENABLE_CODE = 0X60;    //96
		public static int SLDM_START_BUFF_MOVE_CODE = 0X61;    //97
		public static int SLDM_ADD_BUFF_SEGMENT_CODE = 0X62;   //98
		public static int SLDM_RESET_BUFF_SEGMENT_P_CODE = 0X67;   //103
		public static int SLDM_SET_BUFF_MOVE_CURENT_P_CODE = 0X68; //104
		public static int SLDM_STOP_BUFF_MOVE_CODE = 0X69; //105
		public static int SLDM_SET_BUFF_MOVE_SINGLE_STEP_CODE = 0X6A;  //106
		public static int SLDM_RESET_BUFF_MOVE_CODE = 0X6B;    //107
		public static int SLDM_SETBUFFLOOP_CODE = 0X6D;    //109
		public static int SLDM_BUFF_WAIT_INPUT_CODE = 0X6E;    //110
		public static int SLDM_BUFF_DELAY = 0X6F;  //111

        public static int SLDM_TOGGLE_OUTBIT = 0X70;	//112
		public static int SLDM_SETOUTBIT_CODE = 0X73;  //115
		public static int SLDM_SETOUTBYTE_CODE = 0X76; //118
        public static int SLDM_SET_DI_FILTER_CODE = 0x7B;  //123
		public static int SLDM_SETOUTWORD = 0X7C;  //124
		public static int SLDM_SETOUTDWORD = 0X7D; //125
        public static int SLDM_IO_TRIGGER = 0x7E;	//126
		public static int SLDM_REVERSE_OUTBIT = 0X7F;  //127

		public static int SLDM_ARC_2D_CODE = 0X80; //128
		public static int SLDM_ARC_RADIUS_CODE = 0X81; //129
		public static int SLDM_ARC_STOP_CODE = 0X82;   //130
		public static int SLDM_ADD_MIX_SEGMENT_CODE = 0X83;    //131
		public static int SLDM_ADD_MIX_SEG_CODE = 0X84;    //132
		public static int SLDM_BUFF_DELAY_OUTBIT_TO_START_CODE = 0X85; //133
		public static int SLDM_BUFF_DELAY_OUTBIT_TO_STOP_CODE = 0X86;  //134
		public static int SLDM_BUFF_AHEAD_OUTBIT_TO_STOP_CODE = 0X87;  //135
		public static int SLDM_BUFF_CLEAR_IO_ACTION_CODE = 0X88;   //136
		public static int SLDM_ARC_3POINTS_CODE = 0X8A;    //138
		public static int SLDM_SET_GEAR_FOLLOW_CODE = 0X8B;    //139
		public static int SLDMPI_ARC_2DEX_CODE = 0X8C; //140
        public static int SLDM_PTPN_PLUS_CODE = 0X8E;//142
        public static int SLDM_PTPN_STOP_PLUS_CODE = 0X8F;	//143

		public static int SLDM_CMPR_ENABLE_CODE = 0X90;    //144
		public static int SLDM_CMPR_ADD_POINT_CODE = 0X91; //145
		public static int SLDM_CLEAR_CMPR_CODE = 0X93; //147
		public static int SLDM_START_CMPR_CODE = 0X94; //148
		public static int SLDM_COMPARELINEAR_CODE = 0X96;  //150
		public static int SLDM_CMPR_MOD_CODE = 0X97;   //151
		public static int SLDM_CMPR_2D_CODE = 0X98;    //152
		public static int SLDM_START_LATCH_CODE = 0X99;    //153
		public static int SLDM_SET_LATCH_PARA_CODE = 0X9A; //154
		public static int SLDM_CLEAR_LATCH_FIFO_CODE = 0X9C;   //156
        public static int SLDM_CMPR_3D_CODE = 0X9F;	//159

		public static int SLDM_PTINIT_CODE = 0XA0; //160
		public static int SLDM_PRFPT_CODE = 0XA1;  //161
		public static int SLDM_PTSTART_CODE = 0XA3;    //163
		public static int SLDM_PTDATA_CODE = 0XA4; //164
		public static int SLDM_PTCLEAR_CODE = 0XA5;    //165
		public static int SLDM_SETPTLOOP_CODE = 0XA6;  //166
		public static int SLDM_SETPTMEMORY_CODE = 0XAB;    //171

		public static int SLDM_SET_PWM_ENABLE_CODE = 0XB0; //176
		public static int SLDM_PWM_START_CODE = 0XB1;  //177
		public static int SLDM_SET_PWM_CONFIG_CODE = 0XB2; //178
															//public static int	SLDM_SET_GEAR_FOLLOW_CODE		=			0XB6;	//182(���жϵ�����)
		public static int SLDM_BUFF_SET_PWM_OUTPUT = 0XB4; //180
		public static int SLDM_BUFF_SET_PWM_ONOFF_DUTY = 0XB5; //181
		public static int SLDM_BUFF_SET_PWM_FOLLOW_SPEED = 0XB6;   //182
		public static int SLDM_BUFF_DELAY_PWM_TO_START = 0XB7; //183
		public static int SLDM_BUFF_AHEAD_PWM_TO_STOP = 0XB8;  //184

        public static int SLDM_SET_HANDWHEEL_CONFIG	= 0XBD;//189
        public static int SLDM_SET_HANDWHEEL_MAXVEL	= 0XBE;	//190
        public static int SLDM_SET_HANDWHEEL_ENABLE	= 0XBF;	//191

        public static int SLDM_SET_ECAT_AXIS = 0XC0;	//192
        public static int SLDM_ECAT_RESET = 0XC1;	//193


		public static int SLDM_TEST_FUNCTION_CODE = 0XFF;  //255
															//@End ���ش���ID�ĺ������� ����=

		//@Begin PT�˶�ģʽ
		public static int PT_MODE_STATIC = 0;//���ú궨��Ϊ 0����̬ģʽ��Ĭ��Ϊ��ģʽ��
		public static int PT_MODE_DYNAMIC = 1;//���ú궨��Ϊ 1����̬ģʽ
		public static int PT_SEGMENT_NORMAL = 0;//���ú궨��Ϊ 0����ͨ�Ρ�Ĭ��Ϊ�����͡�
		public static int PT_SEGMENT_EVEN = 1;//���ú궨��Ϊ 1�����ٶΡ�
		public static int PT_SEGMENT_STOP = 2;//���ú궨��Ϊ 2�����ٵ� 0 �Ρ�
		public static int PT_SEGMENT_END = 3;// �Զ��������־
											  //@End PT�˶�ģʽ

		public static int MAX_ALM_BUFFER_NUM = 256;

		//������

        public static int E450A = 450;
        public static int E850 = 850;
        public static int E1250 = 1250;
        public static int E1650 = 1650;
        public static int E5080 = 5080;
        public static int E5160 = 5160;

        public static int E6308 = 6308;
        public static int E6508 = 6508;
        public static int E6408 = 6408;
        public static int E6316 = 6316;
        public static int E6516 = 6516;
        public static int E6416 = 6416;
        public static int E6332 = 6332;
        public static int E6532 = 6532;
        public static int E6432 = 6432;
        public static int E6364 = 6364;
        public static int E6564 = 6564;
        public static int E6464 = 6464;

        [StructLayout(LayoutKind.Sequential)]
        public struct CARD_INFO
        {
            public uint Card_ID;
            public uint Lib_SoftVer;
            public uint Arm_SoftVer;
            public uint Arm_GitCommit;
            public uint FPGA_SoftVer;
            public uint FPGA_GitCommit;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public uint[] FPGA_UID;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public uint[] Arm_UID;
            public uint PCB_Ver;
            public uint PCB_GitCommit;
            public uint BOM_Ver;
            public uint BOM_GitCommit;
            public uint Slave_Type;

        }


		public struct Axis_Para
		{
            public bool servo_alarm_en;
            public bool Plimit_en;
            public bool Nlimit_en;
            public bool origin_en;

            public bool servo_alarm_pol;
            public bool Plimit_pol;
            public bool Nlimit_pol;
            public bool origin_pol;

            public bool Dir_pol;
            public bool Enc_pol;
            public bool Encz_pol;

            public bool soft_Plimit_en;
            public bool soft_Nlimit_en;
            public bool pulse_Pol;
			public byte Pulse_Mode;//2 bit

            public int soft_Plimit_pos;
            public int soft_Nlimit_pos;
            public int home_oft_pos;
            public int i_zcap_pulse;//E516 @
		}


		public struct Axis_Status
		{
			public byte servo_alarm_vol;
			public byte Plimit_vol;
			public byte Nlimit_vol;
			public byte origin_vol;
			public byte Encz_vol;
			public byte reached_vol;
			public byte servon;
			public byte resalm;

			public byte servo_alarm_valid;
			public byte Plimit_valid;
			public byte Nlimit_valid;
			public byte origin_valid;
			public byte Encz_valid;
			public byte reached_valid;
			public byte soft_Plimit_valid;
			public byte soft_Nlimit_valid;

			public byte homing;
			public byte homed;
			public byte running;

			public byte alarm_status;//0x01����λ��0x02����λ��0x04 soft_plimit,0x08 soft_nlimit,0x10�ŷ�����
			public byte home_flag;

		}


        [StructLayout(LayoutKind.Sequential)]
        public struct Alarm_History
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public int[] alarm_number;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public int[] alarm_para;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public int[] time_tick;

        }

        public struct Home_Para
        {
            public UInt32 h_dir;
            public UInt32 mode;
            public float low_vel;
            public float high_vel;
            public float acc;
            public UInt32 enc_en;
        }

		public delegate void fn();

		[StructLayout(LayoutKind.Sequential)]
		public struct Jump_Data
		{
			public UInt32 axis_count;               //3,�̶�3��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public uint[] axis_list;     //��ǰָ�������Զ�3������в���;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
			public int[] target_pos;         //����Ŀ��λ�ã���������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public int[] start_pos;          //���λ�ã���������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
			public short[] soft_en;               //�Ƿ�����������������½��־��soft_en[0]-������,soft_en[0]-����½��
			public int soft_upZPos;               //̧������У�������Z��λ������
			public int soft_downZPos;             //�½������У�����½Z��λ������
			public float soft_upVel;               //̧������У��������յ��ٶ�
			public float soft_downVel;             //�½������У�����½�յ��ٶ�
			public int z_sofePos;                 //Z�����½���̧������У���ȫλ��
			public int z_steadyPos;               //Z����Ƹ߶�
			public float start_vel;                //�������˶�����ʼ�ٶ�
			public float end_vel;                  //�������˶����յ��ٶ�
			public float steady_vel;               //�������˶�������ٶ�
			public float move_acc;                 //�˶������еļ��ٶȣ�pulse/ms^2
			public float move_dec;                 //�˶������еļ��ٶȣ�pulse/ms^2
		}


		/**********************************************************************************
		* @Begin E450
		***********************************************************************************/
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ÿ����������������ͺ��б�
		* @param card_num��   ��������������.
		*        type��		  �����������ͺ��б�����
		*						450-E450
		*						6364-E6364
		*						6564-E6564
		*						......
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Card_List(UInt32 IP_4,UInt32 card_num,  UInt32[] type);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�����������������ͺ��б�
		* @param card_num��   ���ؼ�������������.
		*        type��		  ���ؿ����������ͺ��б�����
		*						450-E450
		*						6364-E6364
		*						6564-E6564
		*						......
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Get_Card_List(UInt32 IP_4, ref UInt32 card_num, [Out] UInt32[] type);
        //public static extern int SLDM_Get_Card_List(ref UInt32 card_num, ref UInt32[] type);
		/**********************************************************************************
		* @End E450
		***********************************************************************************/


		/***************************************************************************************************
		*		�����ӿ�
		***************************************************************************************************/

		/**********************************************************************************
		* @Begin ����������
		***********************************************************************************/

		//********************************************************************************************************************************************************************
		/**
		* @brief �򿪿�����
		* @param card_no��   �����Ŀ���
		*        type��      ��̫�����䷽ʽ,ȡֵ��Χ��
		*						0-UDP (Ĭ��)
		*						1-wincap
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Open(UInt32 IP_4, UInt32 card_no, UInt32 type = 0);

		//********************************************************************************************************************************************************************
		/**
		* @brief �رտ�����
		* @param card_no��   0
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Close(UInt32 card_no);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ÿ�������СͨѶ����
		* @param card_no��	0
		*		 period��	��СͨѶ����ģʽ����λus��ȡֵ��Χ��0-1000.Ĭ��ֵ800.
		* @return �ɹ�����0.
		* @remark ����ģʽʱ��������������ͨѶ���ڹ�����������
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Comm_Period(UInt32 card_no, UInt32 period);//us
																					//********************************************************************************************************************************************************************
		/**
		* @brief ���ÿ���������ģʽ
		* @param card_no��	0
		*		 model��	ģʽ��0-�ǵ���ģʽ��1-����ģʽ
		* @return �ɹ�����0.
		* @remark ����ģʽʱ��������������ͨѶ���ڹ�����������
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Debug_Mode(UInt32 card_no, UInt32 mode);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ����������
		* @param card_no��	0
		*		 ticks��	���ؿ���������ֵ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_SysTicks(UInt32 card_no, ref UInt32 ticks);

		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ������������״̬
		* @param card_no��	�����Ŀ���
		*		 status��	���ؿ�����������״̬��
		*						0-������
		*						-1-δ����
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_ConnStatus(UInt32 card_no, ref int status);

		/**********************************************************************************
		* @End ����������
		***********************************************************************************/

		/**********************************************************************************
		* @Begin �������״̬��д
		***********************************************************************************/

		//********************************************************************************************************************************************************************
		/**
		* @brief �����������ģʽ
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 mode��		ģʽֵ��
		*						0-����+����
		*						1-AB��
		*						2-˫����
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Pulse_Mode(UInt32 card_no, UInt32 axis, UInt32 mode);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���������弫��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pol��		����ֵ��
		*						0-������ (Ĭ��)
		*						1-������
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Pulse_Pol(UInt32 card_no, UInt32 axis, UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���������巽����
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pol��		����ֵ��
		*						0-������ (Ĭ��)
		*						1-������
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Dir_Pol(UInt32 card_no, UInt32 axis, UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief �����������������
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pol��		����ֵ��
		*						0-������ (Ĭ��)
		*						1-������
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Enc_Pol(UInt32 card_no, UInt32 axis, UInt32 pol);
        //********************************************************************************************************************************************************************
        /**
        * @brief �����������ʹ��
        * @param card_no��	�����Ŀ���
        *		 axis��		��ѡ��(0-3)
        *		 en��		ʹ��ֵ��
        *						0-��ʹ��
        *						1-ʹ�� (Ĭ��)
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Set_Enc_Enable(UInt32 card_no, UInt32 axis, UInt32 en);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ö�ȡ��������������
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 mult��		��������ֵ��Ĭ��ֵ4��4��Ƶ��.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Enc_Mult(UInt32 card_no, UInt32 axis, UInt32 mult);
		//********************************************************************************************************************************************************************
		/**
		* @brief �����ᵱǰλ��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pos��		λ�� ����λ������.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Cpos(UInt32 card_no, UInt32 axis, int pos);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�ᵱǰλ��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pos��		���ص�ǰλ�� ����λ������.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Pos(UInt32 card_no, UInt32 axis, ref Int32 pos);
		//********************************************************************************************************************************************************************
		/**
		* @brief �����ᵱǰ������λ��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pos��		λ�� ����λ������.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Enc(UInt32 card_no, UInt32 axis, int pos);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�ᵱǰ������λ��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pos��		���ص�ǰ������λ�� ����λ������.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Get_Enc(UInt32 card_no, UInt32 axis, ref Int32 pos);


		/*
		         * @brief ��ȡ�����������������ͺ��б�
		         * SLDM_Get_Card_List_IP �˺�����ʱ�޷�����
		         * 
        * @param 
        *		 IP_1��      ����IP��ַ��1λ        
        *		 IP_2��      ����IP��ַ��2λ        
        *		 IP_3��      ����IP��ַ��3λ
        *		 IP_4��      ����IP��ַ��4λ
        *		 ip_4��      ��ip��ַ����λ      		 
        *        cardlist_num��   ���ؼ�������������.
        *        type��		  ���ؿ����������ͺ��б�����
        *						450-E450
        *						6364-E6364
        *						6564-E6564
        *						......
        * @return �ɹ�����0.
        * @remark
		 */
		//sldmv.SLDM_Get_Card_List_IP(PC_IP_1, PC_IP_2, PC_IP_3, PC_IP_4, ip_4, &cardlist_num, type);
		//public static extern long SLDM_Get_Card_List(ref ulong card_num, ref UInt32[] type);
		[DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Card_List_IP(UInt32 IP_1, UInt32 IP_2, UInt32 IP_3, UInt32 IP_4, UInt32 ip_4, ref UInt32 cardlist_num, [Out] UInt32[] type);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ñ�����Z�źŲ���
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pol��		��Ч��ƽ��0-�͵�ƽ��1-�ߵ�ƽ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_EncZ_Pol(UInt32 card_no, UInt32 axis, UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ������Z�źŵ�ƽ
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 valid��	���ر�����z�ź���Ч״̬��0-��Ч��1-��Ч.
		*		 el��		���ر�����z�źŵ�ƽ��0-�͵�ƽ��1-�ߵ�ƽ.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Enc_Z(UInt32 card_no, UInt32 axis, ref UInt32 valid, ref UInt32 el);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ü�ͣ����
		* @param card_no��	�����Ŀ���
		*		 en��		ʹ�� 0-��ʹ�ܣ�1-ʹ�� (Ĭ�ϲ�ʹ��)
		*		 pol��		��ͣ��Чֵ��0-���벻��ͨ��1-���뵼ͨ (Ĭ��1-���뵼ͨ)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_EMG_Config(UInt32 card_no, UInt32 en, UInt32 pol);

		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ��ͣ����
		* @param card_no��	�����Ŀ���
		*		 en��		ʹ�� 0-��ʹ�ܣ�1-ʹ�� 
		*		 pol��		��ͣ��Чֵ��0-���벻��ͨ��1-���뵼ͨ 
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_EMG_Config(UInt32 card_no, ref UInt32 en, ref UInt32 pol);

		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ��ͣ�ź�״̬
		* @param card_no��	�����Ŀ���
		*		 valid��	���ر�����z�ź���Ч״̬��0-��Ч��1-��Ч.
		*		 el��		���ر�����z�źŵ�ƽ��0-�͵�ƽ��1-�ߵ�ƽ.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_EMG(UInt32 card_no, ref UInt32 valid, ref UInt32 el);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ø����ŷ�ʹ��״̬
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 on��		ʹ�ܶ˿ڵ�ͨ״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_ServoOn(UInt32 card_no, UInt32 axis, UInt32 on);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�����ŷ�ʹ��״̬
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 on��		����ʹ�ܶ˿ڵ�ͨ״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_ServoOn(UInt32 card_no, UInt32 axis, ref UInt32 on);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ø����ŷ��������״̬
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 on��		��������˿ڵ�ͨ״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_RstAlm(UInt32 card_no, UInt32 axis, UInt32 on);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�����ŷ��������״̬
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 on��		��������˿ڵ�ͨ״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_RstAlm(UInt32 card_no, UInt32 axis, ref UInt32 on);
		//********************************************************************************************************************************************************************
		/**
		* @brief ����������λ����
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 en��		ʹ�� 0-��ʹ�ܣ�1-ʹ�� (Ĭ�ϲ�ʹ��)
		*		 pol��		��λ��Чֵ��0-���벻��ͨ��1-���뵼ͨ (Ĭ��1-���뵼ͨ)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Plimit_Config(UInt32 card_no, UInt32 axis, UInt32 en, UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ������λ����
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 en��		����ʹ��״̬ 0-��ʹ�ܣ�1-ʹ�� (Ĭ�ϲ�ʹ��)
		*		 pol��		������λ��Чֵ״̬��0-���벻��ͨ��1-���뵼ͨ (Ĭ��1-���뵼ͨ)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Plimit_Config(UInt32 card_no, UInt32 axis, ref UInt32 en, ref UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ����������λ����״̬
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 valid��	������λ��Ч״ֵ̬ 0-��Ч��1-��Ч
		*		 el��		������λ�ӿڵ�ͨ״ֵ̬0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_POT(UInt32 card_no, UInt32 axis, ref UInt32 valid, ref UInt32 el);
		//********************************************************************************************************************************************************************
		/**
		* @brief �����Ḻ��λ����
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 en��		ʹ�� 0-��ʹ�ܣ�1-ʹ�� (Ĭ�ϲ�ʹ��)
		*		 pol��		��λ��Чֵ��0-���벻��ͨ��1-���뵼ͨ (Ĭ��1-���뵼ͨ)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Nlimit_Config(UInt32 card_no, UInt32 axis, UInt32 en, UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�Ḻ��λ����
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 en��		����ʹ��״̬ 0-��ʹ�ܣ�1-ʹ�� (Ĭ�ϲ�ʹ��)
		*		 pol��		������λ��Чֵ״̬��0-���벻��ͨ��1-���뵼ͨ (Ĭ��1-���뵼ͨ)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Nlimit_Config(UInt32 card_no, UInt32 axis, ref UInt32 en, ref UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ���Ḻ����λ����״̬
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 valid��	������λ��Ч״ֵ̬ 0-��Ч��1-��Ч
		*		 el��		������λ�ӿڵ�ͨ״ֵ̬0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_NOT(UInt32 card_no, UInt32 axis, ref UInt32 valid, ref UInt32 el);
		//********************************************************************************************************************************************************************
		/**
		* @brief ������ԭ�����
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 en��		ʹ�� 0-��ʹ�ܣ�1-ʹ�� (Ĭ�ϲ�ʹ��)
		*		 pol��		ԭ����Чֵ��0-���벻��ͨ��1-���뵼ͨ (Ĭ��1-���뵼ͨ)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Org_Config(UInt32 card_no, UInt32 axis, UInt32 en, UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ��ԭ�����
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 en��		����ʹ��״̬ 0-��ʹ�ܣ�1-ʹ�� (Ĭ�ϲ�ʹ��)
		*		 pol��		����ԭ����Чֵ״̬��0-���벻��ͨ��1-���뵼ͨ (Ĭ��1-���뵼ͨ)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Org_Config(UInt32 card_no, UInt32 axis, ref UInt32 en, ref UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ����ԭ�㿪��״̬
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 valid��	����ԭ�㿪����Ч״ֵ̬ 0-��Ч��1-��Ч
		*		 el��		����ԭ�㿪�ؽӿڵ�ͨ״ֵ̬0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Org(UInt32 card_no, UInt32 axis, ref UInt32 valid, ref UInt32 el);
		//********************************************************************************************************************************************************************
		/**
		* @brief �������ŷ���������
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 en��		ʹ�� 0-��ʹ�ܣ�1-ʹ�� (Ĭ�ϲ�ʹ��)
		*		 pol��		���ŷ�������Чֵ��0-���벻��ͨ��1-���뵼ͨ (Ĭ��1-���뵼ͨ)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_ServoAlm_Config(UInt32 card_no, UInt32 axis, UInt32 en, UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ���ŷ���������
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 en��		����ʹ��״̬ 0-��ʹ�ܣ�1-ʹ�� (Ĭ�ϲ�ʹ��)
		*		 pol��		���ر�����Чֵ״̬��0-���벻��ͨ��1-���뵼ͨ (Ĭ��1-���뵼ͨ)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_ServoAlm_Config(UInt32 card_no, UInt32 axis, ref UInt32 en, ref UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�����ŷ���������״̬
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 valid��	�����ŷ���������Ч״ֵ̬ 0-��Ч��1-��Ч
		*		 el��		�����ŷ������ӿڵ�ͨ״ֵ̬0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Servo_Alarm(UInt32 card_no, UInt32 axis, ref UInt32 valid, ref UInt32 el);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ���᷽���Բ���
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 Dir_pol��	�������巽������״̬ 0-������1-������
		*		 Pulse_Pol���������弫������״̬ 0-�����ԣ�1-������
		*		 Enc_pol��	���ر�������������״̬ 0-�����ԣ�1-������
		*		 Encz_pol��	���ر�����Z�źż�������״̬ 0-�����ԣ�1-������
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_AxisPol_Config(UInt32 card_no, UInt32 axis, ref UInt32 Dir_pol, ref UInt32 Pulse_Pol, ref UInt32 Enc_pol, ref UInt32 Encz_pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ��������ṹ
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 p_axispara������������ṹ��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Axis_Para(UInt32 card_no, UInt32 axis, ref Axis_Para p_axispara);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ñ������˲�ʱ��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 filter_time���˲�ʱ�䣬��λus��Ĭ��ֵ0.2-20ns.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Enc_Filter(UInt32 card_no, UInt32 axis, float filter_time);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��������������˲�ʱ��
		* @param card_no��	�����Ŀ���
		*		 input_bit��DIλѡ��(0-15)
		*		 filter_time���˲�ʱ�䣬��λus��Ĭ��ֵ1-1us.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_DI_Filter(UInt32 card_no, UInt32 input_bit, float filter_time);
		//********************************************************************************************************************************************************************
		/**
		* @brief ������λ��ԭ�㡢��λ�����ź��˲�ʱ��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 filter_time���˲�ʱ�䣬��λus��Ĭ��ֵ1000-1ms.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Spec_Input_Filter(UInt32 card_no, UInt32 axis, float filter_time);
		//********************************************************************************************************************************************************************
		/**
		* @brief �����ᱨ���ź��˲�ʱ��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 filter_time���˲�ʱ�䣬��λus��Ĭ��ֵ1000-1ms.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Axis_Input_Filter(UInt32 card_no, UInt32 axis, float filter_time);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ���˶���Ŀ��λ��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pos��		���ص�ǰ�˶�Ŀ��λ�� ����λ������.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_PosT(UInt32 card_no, UInt32 axis, ref int pos);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ���˶��Ĺ켣�滮λ��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pos��		���ص�ǰ�˶��켣�滮λ�� ����λ������.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_PosA(UInt32 card_no, UInt32 axis, ref int pos);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ���˶��ٶ�
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 vel��		�����ᵱǰ�ٶȣ���λ��p/ms
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Vel(UInt32 card_no, UInt32 axis, ref float vel);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡֱ�߲岹��Բ���岹�˶��ٶ�
		* @param card_no��	�����Ŀ���
		*		 line_vel��	����ֱ�߲岹��ǰ�ٶȣ���λ��p/ms
		*		 arc_vel��	����Բ���岹��ǰ�ٶȣ���λ��p/ms
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_ExVel(UInt32 card_no, ref float line_vel, ref float arc_vel);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ����λԭ���״̬�ṹ��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 p_axissatus��������״̬�ṹ��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Axis_Status(UInt32 card_no, UInt32 axis, ref Axis_Status p_axissatus);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ���ᵽλ����״̬
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 valid��	���ص�λ������Ч״ֵ̬ 0-��Ч��1-��Ч
		*		 el��		���ص�λ���ؽӿڵ�ͨ״ֵ̬0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Reached(UInt32 card_no, UInt32 axis, ref UInt32 valid, ref UInt32 el);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�������˶�״̬
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 running��	�������˶�״̬��0-ֹͣ��1-�˶�
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Running(UInt32 card_no, UInt32 axis, ref UInt32 running);
		//********************************************************************************************************************************************************************
		/**
		* @brief �Ḵλ
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Reset(UInt32 card_no, UInt32 axis);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�����ۺϱ�����Ϣ
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 p_almstatus�����ظ��ᱨ����Ϣ״̬
		* @return �ɹ�����0.
		* @remark 0x01����λ��0x02����λ��0x04 ������λ,0x08 ������λ,0x10�ŷ�����
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Axis_AlmStatus(UInt32 card_no, UInt32 axis, ref UInt32 p_almstatus);
		//********************************************************************************************************************************************************************
        /**
        * @brief ��ȡ����ʷ������Ϣ
        * @param card_no��	�����Ŀ���
        *		 p_alarmhistory����������ʷ�����ṹ
        * @return ������ʷ��������.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Alarm_History(UInt32 card_no, ref Alarm_History p_alarmhistory);
		//********************************************************************************************************************************************************************
		/**
		* @brief �������ʷ������Ϣ
		* @param card_no��	�����Ŀ���
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Clear_Alarm_History(UInt32 card_no);
		//********************************************************************************************************************************************************************
        /**
        * @brief ��ȡ���������һ�ε���ʷ������Ϣ
        * @param card_no��	�����Ŀ���
        *		 p_Alarm_number�����ر�����־
        *		 p_Alarm_para�����ر�������
        *		 p_time_tick�����ر�������
        * @return ������ʷ��������.
        * @remark 0x01����λ��0x02����λ��0x04 ������λ,0x08 ������λ,0x10�ŷ�����
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_AlarmHistory(UInt32 card_no, [Out] int[] p_Alarm_number, [Out]  int[] p_Alarm_para, [Out]  int[] p_time_tick);

		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�������Ϣ
		* @param card_no��	�����Ŀ���
		*		 err��		�����������룬��������0.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Move_Error(UInt32 card_no, ref int err);

		/**********************************************************************************
		* @End �������״̬��д
		***********************************************************************************/

		/**********************************************************************************
		* @Begin ����
		***********************************************************************************/


		//********************************************************************************************************************************************************************
		/**
		* @brief ���������ƫ�ò���
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pos��		����ƫ��λ�ã���λ������.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Home_Oft(UInt32 card_no, UInt32 axis, int pos);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��������λ����
		* @param card_no��	�����Ŀ���
		*		 axis_mask����λ�����ʾ����ѡ��
		*		 en��		����ƫ��λ�ã���λ������.
		*		 p_pos��	����λλ�ã���λ������
		*		 n_pos��	����λλ�ã���λ������
		* @return �ɹ�����0.
		* @remark ����λ�ڻ�����ɺ���Ч
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Soft_Limit(UInt32 card_no, UInt32 axis, UInt32 en, int p_pos, int n_pos);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ��������λ����
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 en��		��������λʹ������״̬ 0-��ʹ�ܣ�1-ʹ��
		*		 p_pos��	����������λλ��
		*		 n_pos��	���ظ�����λλ��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Soft_Limit(UInt32 card_no, UInt32 axis, ref UInt32 en, ref int p_pos, ref int n_pos);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���û������
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 h_dir��	���㷽��0-����1-����.
		*		 low_vel��	�����ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 high_vel��	�����ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000.
		*		 mode��		����ģʽ��
		*                       0- ԭ�ػ���
		*                       1- һ��ԭ�����
		*                       2- һ����λ����
		*                       3- һ��ԭ�����ӻ���
		*                       4- һ����λ����ӻ���
		*                       5- ����ԭ�����
		*                       6- ������λ����
		*                       7- EZ �źŻ���
		*                       8- ԭ�������ٻ��� EZ �ź�
		*                       9- ��λ������ٻ��� EZ �ź�
		*                       10- ԭ������
		*                       11- ��λ����
		*                       12- EZ�ź� ����
		*                       13- ԭ�����ӷ��� EZ ����
		*                       14- ��λ����ӷ��� EZ ����
		*		 enc_en��	���ñ�������Ч��0-��Ч��1-��Ч
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Home_Para(UInt32 card_no, UInt32 axis, UInt32 h_dir, float low_vel, float high_vel, float acc, UInt32 mode, UInt32 enc_en);

		//********************************************************************************************************************************************************************
		/**
		* @brief ���������˶�
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Home_Move(UInt32 card_no, UInt32 axis);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�����״̬
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 homing��	�����������״̬��0-���ڻ�������У�1-�ڻ��������
		*		 homed��	������������״̬��0-����δ��ɣ�1-�������
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Homing(UInt32 card_no, UInt32 axis, ref UInt32 homing, ref UInt32 homed);

		/**********************************************************************************
		* @End  ����
		***********************************************************************************/


		/**********************************************************************************
		* @Begin �����˶�
		***********************************************************************************/

		//********************************************************************************************************************************************************************
		/**
		* @brief ��������ʽ P2P �˶�
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pos��		Ŀ��λ�ã���λ pulse����Χ-2 31 ~2 31
		*		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 sine��		�������ߣ�0-T�ͣ�1-S��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_JogA(UInt32 card_no, UInt32 axis, int pos, float start_vel, float steady_vel, float acc, UInt32 sine);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��������ʽ P2P �˶����ǶԳƵ�λ�˶���
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pos��		Ŀ��λ�ã���λ pulse����Χ-2 31 ~2 31
		*		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 end_vel��	�յ��ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 dec��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 sine��		�������ߣ�0-T�ͣ�1-S��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PTP1(UInt32 card_no, UInt32 axis, Int32 pos, float start_vel, float steady_vel, float end_vel, float acc, float dec, UInt32 sine);

		//********************************************************************************************************************************************************************
		/**
		* @brief �������ʽ P2P �˶����ǶԳƵ�λ�˶���
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pos��		���Ŀ��λ�ã���λ pulse����Χ-2 31 ~2 31
		*		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 end_vel��	�յ��ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 dec��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 sine��		�������ߣ�0-T�ͣ�1-S��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PTP1R(UInt32 card_no, UInt32 axis, int pos, float start_vel, float steady_vel, float end_vel, float acc, float dec, UInt32 sine);
		//********************************************************************************************************************************************************************
		/**
		* @brief �������������˶�
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 acc��		Ŀ���(��)�ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_JogP(UInt32 card_no, UInt32 axis, float start_vel, float steady_vel, float acc);
		//********************************************************************************************************************************************************************
		/**
		* @brief �������������˶�
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 acc��		Ŀ���(��)�ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_JogM(UInt32 card_no, UInt32 axis, float start_vel, float steady_vel, float acc);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���˶�����ֹͣ����� P2P��Jog��Home ���˶�
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 stop_dec��	����ֹͣ���ٶȣ����Ϊ������Ĭ�ϼ��ٶ�ֹͣ.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Stop(UInt32 card_no, UInt32 axis, float stop_dec);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���˶�����ֹͣ����� P2P��Jog��Home ���˶�
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Estop(UInt32 card_no, UInt32 axis);
		//********************************************************************************************************************************************************************
		/**
		* @brief �ı����˶��յ�λ��
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 pos��		Ŀ��λ�ã���λ pulse����Χ-2 31 ~2 31
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Change_Pos(UInt32 card_no, UInt32 axis, int pos);
		//********************************************************************************************************************************************************************
		/**
		* @brief �ı����˶��ٶ�
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��(0-3)
		*		 vel��		Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Change_Vel(UInt32 card_no, UInt32 axis, float vel);
		/**********************************************************************************
		* @End �����˶�
		***********************************************************************************/


		/**********************************************************************************
		* @Begin �����˶�
		***********************************************************************************/
		//********************************************************************************************************************************************************************
		/**
		* @brief ����ֱ�ߵ�λ�˶�
		* @param card_no��	�����Ŀ���
		*		 n_axis��	�˶������1-7
		*		 p_axis��	�������
		*		 pos��		����Ŀ��λ�����飬��λ pulse����Χ-2 31 ~2 31
		*		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000		
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000		
		*		 end_vel��	�յ��ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000	
		*		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 dec��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 sine��		�������ߣ�0-T�ͣ�1-S��		
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_PTPn(UInt32 card_no, UInt32 n_axis, UInt32[] axislist, Int32[] pos, float start_vel, float steady_vel, float end_vel, float acc, float dec, UInt32 sine);
		//********************************************************************************************************************************************************************
		/**
		* @brief ����ֱ�ߵ�λ�˶�
		* @param card_no��	�����Ŀ���
		*		 stop_dec��	����ֹͣ���ٶȣ����Ϊ������Ĭ�ϼ��ٶ�ֹͣ.	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PTPn_Stop(UInt32 card_no, float stop_dec);
        //********************************************************************************************************************************************************************
        /**
        * @brief ����ŵĶ���ֱ�ߵ�λ�˶�
        * @param card_no��	�����Ŀ���
        *		 group_id��	��ţ�������������ţ�ÿ������˶���ֹͣ.��Χ��0-�������/2
        *		 n_axis��	�˶������1-7
        *		 p_axis��	�������
        *		 pos��		����Ŀ��λ�����飬��λ pulse����Χ-2 31 ~2 31
        *		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000		
        *		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000		
        *		 end_vel��	�յ��ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000	
        *		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
        *		 dec��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
        *		 sine��		�������ߣ�0-T�ͣ�1-S��		
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_PTPn_Group(UInt32 card_no, UInt32 group_id, UInt32 n_axis, UInt32[] axislist, Int32[] pos, float start_vel, float steady_vel, float end_vel, float acc, float dec, UInt32 sine);

		/// <summary>
		/// �򿪿��ƿ�
		/// </summary>
		/// <param name="PC_IP_1"></param>������ַ 1
		/// <param name="PC_IP_2"></param>������ַ 2
		/// <param name="PC_IP_3"></param>������ַ 3
		/// <param name="PC_IP_4"></param>������ַ 4
		/// <param name="ip_4"></param>�ӻ�/�� ip��ַ 4
		/// <returns> �ɹ����� 0
		/// </returns>
		[DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Open_IP(UInt32 PC_IP_1, UInt32 PC_IP_2, UInt32 PC_IP_3, UInt32 PC_IP_4, UInt32 ip_4);
		//********************************************************************************************************************************************************************
		/**
        * @brief ֹͣ����ֱ�ߵ�λ�˶�
        * @param card_no��	�����Ŀ���
        *		 group_id��	��ţ�������������ţ�ÿ������˶���ֹͣ.��Χ��0-�������/2
        *		 stop_dec��	����ֹͣ���ٶȣ����Ϊ������Ĭ�ϼ��ٶ�ֹͣ.	
        * @return �ɹ�����0.
        * @remark
        */
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_PTPn_Stop_Group(UInt32 card_no,UInt32 group_id,float stop_dec);
        //********************************************************************************************************************************************************************
        /**
        * @brief ����ֱ�ߵ�λ�˶�����չ������������滮��ʽ��
        * @param card_no��	�����Ŀ���
        *		 n_axis��	�˶������1-7
        *		 p_axis��	�������
        *		 pos��		����Ŀ��λ�����飬��λ pulse����Χ-2 31 ~2 31
        *		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000		
        *		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000		
        *		 end_vel��	�յ��ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000	
        *		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
        *		 dec��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
        *		 sine��		�������ߣ�0-T�ͣ�1-S��		
        * @return �ɹ�����0.
        * @remark ��SLDM_PTPn_Stop_Plus ���ʹ��
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_PTPn_Plus(UInt32 card_no, UInt32 n_axis, UInt32[] axislist, Int32[] pos, float start_vel, float steady_vel, float end_vel, float acc, float dec, UInt32 sine);
        //********************************************************************************************************************************************************************
        /**
        * @brief ֹͣ����ֱ�ߵ�λ�˶�����չ������������滮��ʽ��
        * @param card_no��	�����Ŀ���
        *		 stop_dec��	����ֹͣ���ٶȣ����Ϊ������Ĭ�ϼ��ٶ�ֹͣ.	
        * @return �ɹ�����0.
        * @remark ��SLDM_PTPn_Plus ���ʹ��
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_PTPn_Stop_Plus(UInt32 card_no,float stop_dec);
        
		/**********************************************************************************
		* @End �����˶�
		***********************************************************************************/


		/**********************************************************************************
		* @Begin Բ���˶�
		***********************************************************************************/

		//********************************************************************************************************************************************************************
		/**
		* @brief ��άԲ���˶���Բ�ģ�
		* @param card_no��	�����Ŀ���
		*		 axislist��	��ά�������	
		*		 center_pos����άԲ��λ�����飬��λ���������		
		*		 end_pos��	��ά�յ�λ�ã���λ���������
		*		 ccw_dir��	Բ������0-��ʱ�룬1-˳ʱ��
		*		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 end_vel��	�յ��ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 dec��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		* @return �ɹ�����0.
		* @remark 
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Arc_2D(UInt32 card_no,  UInt32[] axislist,  float[] center_pos,  int[] end_pos, UInt32 ccw_dir, float start_vel, float steady_vel, float end_vel, float acc, float dec);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��չ��άԲ���˶���Բ�ģ�
		* @param card_no��	�����Ŀ���
		*		 axislist��	��ά�������	
		*		 center_pos����άԲ��λ�����飬��λ���������		
		*		 end_pos��	��ά�յ�λ�ã���λ���������
		*		 circle��	Ȧ������λ��Ȧ��0��һ��Բ��		
		*		 oft_pos��	���������������ȣ���λ���������
		*		 ccw_dir��	Բ������0-��ʱ�룬1-˳ʱ��
		*		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 end_vel��	�յ��ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 dec��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		* @return �ɹ�����0.
		* @remark 
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDMpi_Arc_2DEx(UInt32 card_no,  UInt32[] axislist,  float[] center_pos,  int[] end_pos, int circle, int oft_pos, UInt32 ccw_dir, float start_vel, float steady_vel, float end_vel, float acc, float dec);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��άԲ���˶����뾶��
		* @param card_no��	�����Ŀ���
		*		 axislist��	��ά�������			
		*		 end_pos��	��ά�յ�λ�ã���λ���������
		*		 arc_Radius��Բ���뾶����λ���������
		*		 ccw_dir��	Բ������0-��ʱ�룬1-˳ʱ��
		*		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 end_vel��	�յ��ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 dec��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		* @return �ɹ�����0.
		* @remark 
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Arc_Radius(UInt32 card_no,  UInt32[] axislist,  int[] end_pos, float arc_Radius, UInt32 ccw_dir, float start_vel, float steady_vel, float end_vel, float acc, float dec);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���������άԲ���岹�˶�
		* @param card_no��	�����Ŀ���	
		*		 axislist��	����б�
		*		 mid_pos��	�м�λ�����飬��λ������
		*		 target_pos��Ŀ��λ�����飬��λ������
		*		 start_vel����ʼ�ٶ�
		*		 steady_vel������ٶ�
		*		 end_vel��	�յ��ٶ�
		*		 acc��		���ٶ�
		*		 dec��		���ٶ�
		* @return �ɹ�����0.
		* @remark 
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Arc_3Points(UInt32 card_no,  UInt32[] axislist,  float[] mid_pos,  int[] target_pos, float start_vel, float steady_vel, float end_vel, float acc, float dec);


		//********************************************************************************************************************************************************************
		/**
		* @brief ��άԲ���˶�ֹͣ
		* @param card_no��	�����Ŀ���
		*		 stop_dec��	����ֹͣ���ٶȣ����Ϊ������Ĭ�ϼ��ٶ�ֹͣ.			
		* @return �ɹ�����0.
		* @remark 
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Arc_Stop(UInt32 card_no, float stop_dec);


		/**********************************************************************************
		* @End Բ���˶�
		***********************************************************************************/


		/**********************************************************************************
		* @Begin �߼��˶�����
		***********************************************************************************/

		//********************************************************************************************************************************************************************
		/**
		* @brief ����ͣ������
		* @param card_no��	�����Ŀ���	
		*		 axis��		��ţ�0-3��
		*		 mid_pos��	�м��λ�ã���һ�� move �յ�λ��,��λ��pulse
		*		 target_pos���ڶ��� move �յ�λ��,��λ��pulse
		*		 start_vel����һ�� move ��ʼ�ٶ� 
		*		 steady_vel����һ�� move ����ٶ�
		*		 stop_vel��	��һ�� move ֹͣ�ٶ�
		*		 delay_ms��	��һ�׶���ɺ��ӳ�ʱ�䣨��λ�����룩
		*		 steady_vel2���ڶ��� move ����ٶ�
		*		 end_vel��	�ڶ��� move ֹͣ�ٶ�
		*		 acc_ms��	����ʱ��(��λ��ms)
		*		 dec_ms��	����ʱ��(��λ��ms)
		*		 posi_mode���˶�ģʽ��0�����ģʽ��1������ģʽ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Pmove_Extern(UInt32 card_no, UInt32 axis, int mid_pos, int target_pos, float start_vel, float steady_vel, float stop_vel,
								   UInt32 delay_ms, float steady_vel2, float end_vel, UInt32 acc_ms, UInt32 dec_ms, UInt32 posi_mode);



		//********************************************************************************************************************************************************************
        /**
        * @brief ���Ÿ��湦��
        * @param card_no��	�����Ŀ���	
        *		 axis��		��������ţ�ȡֵ��Χ��0-3
        *		 enable��	ʹ��״̬��0����ֹ��1��ʹ��
        *		 master_axis������������ţ�ȡֵ��Χ��0-3
        *		 ratio��	���汶��
        *		 src��		λ��Դ 0-����λ�� 1-������λ��
        *       delay:		��������ʱ�����˶���ʱʱ�䣬��λ��ms 0-����ʱ ȡֵ��Χ��0-1000
        * @return �ɹ�����0.
        * @remark 
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Set_Gear_Follow(UInt32 card_no, UInt32 axis, UInt32 enable, UInt32 master_axis, float ratio, UInt32 src, UInt32 delay);
		/**********************************************************************************
		* @End �߼��˶�����
		***********************************************************************************/

		/**********************************************************************************
		* @Begin �������˶�
		***********************************************************************************/



		//********************************************************************************************************************************************************************
		/**
		* @brief ����ֱ�������˶�ʹ��
		* @param card_no��	�����Ŀ���
		*		 enable��	0-���ܣ�1-ʹ��	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Buff_Enable(UInt32 card_no, UInt32 enable);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��������ֱ�������˶�
		* @param card_no��	�����Ŀ���
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Start_Buff_Move(UInt32 card_no);
		//********************************************************************************************************************************************************************
		/**
		* @brief д�뻺����ֱ���˶�����
		* @param card_no��	�����Ŀ���
		*		 n_axis��	�˶�����������4�ᣩ	
		*		 p_axis��	�������	
		*		 pos��		����Ŀ��λ�����飬��λ pulse����Χ-2 31 ~2 31
		*		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000		
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 end_vel��	�յ��ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000	
		*		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 dec��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 sine��		�������ߣ�0-T�ͣ�1-S��
			
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Add_Buff_Segment(UInt32 card_no, UInt32 n_axis,  UInt32[] axislist,  int[] pos, float start_vel, float steady_vel, float end_vel, float acc, float dec, UInt32 sine);
		
		//********************************************************************************************************************************************************************
		/**
		* @brief �õ������˶���ǰ�������˶�����
		* @param card_no��	�����Ŀ���
		*		 p��		���������˶���ǰ�˶�����ֵ	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Buff_Move_Curent_P(UInt32 card_no, ref UInt32 p);
		//********************************************************************************************************************************************************************
		/**
		* @brief �õ������˶���ǰ���˶�����
		* @param card_no��	�����Ŀ���
		*		 p��		���������˶���ǰ�˶��ܶ���ֵ	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Buff_Move_Total_P(UInt32 card_no, ref UInt32 p);
		//********************************************************************************************************************************************************************
		/**
		* @brief �õ������˶���ǰ������д�����
		* @param card_no��	�����Ŀ���
		*		 p��		���ص�ǰ������д�����ֵ	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Buff_Segment_P(UInt32 card_no, ref UInt32 p);
		//********************************************************************************************************************************************************************
		/**
		* @brief �õ������˶���ǰblock������ʣ�����
		* @param card_no��	�����Ŀ���
		*		 space��		���ص�ǰblock��������ʣ�����	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Buff_Block_Space(UInt32 card_no, ref UInt32 space);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��λ�����˶���ǰblock������ָ��
		* @param card_no��	�����Ŀ���	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_ReSet_Buff_Segment_P(UInt32 card_no);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���õ�ǰ�˶�������ָ��λ��
		* @param card_no��	�����Ŀ���
		*		 run_buffer���������ţ�0-1	
		*		 curent_p��	�˶�������ָ��λ��	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Buff_Move_Curent_P(UInt32 card_no, UInt32 run_buffer, UInt32 curent_p);
		//********************************************************************************************************************************************************************
		/**
		* @brief �����������˶�����ֹͣ
		* @param card_no��	�����Ŀ���
		*		 stop_dec��	����ֹͣ���ٶȣ����Ϊ������Ĭ�ϼ��ٶ�ֹͣ.	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Stop_Buff_Move(UInt32 card_no, float stop_dec);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���û��������������˶�
		* @param card_no��	�����Ŀ���
		*		 one_step��	0-�����˶���1-�����˶�	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Buff_Move_Single_Step(UInt32 card_no, UInt32 one_step);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��λ�����˶�����
		* @param card_no��	�����Ŀ���
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Reset_Buff_Move(UInt32 card_no);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�����˶���������״̬
		* @param card_no��	�����Ŀ���
		*		 running��	�������˶�״̬ 0-ֹͣ��1-�������С�	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Running_BuffMove(UInt32 card_no, ref UInt32 running);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���������˶�ѭ������
		* @param card_no��	�����Ŀ���
		*		 loop��		ѭ��������0-����ѭ����	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Buff_Loop(UInt32 card_no, UInt32 loop);
		//********************************************************************************************************************************************************************
		/**
		* @brief д�뻺��������˶�����
		* @param card_no��	�����Ŀ���
		*		 n_axis��	�˶�����������4�ᣩ	
		*		 p_axis��	�������	
		*		 pos��		����Ŀ��λ�����飬��λ pulse����Χ-2 31 ~2 31
		*		 start_vel����ʼ�ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000		
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 end_vel��	�յ��ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000	
		*		 acc��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 dec��		Ŀ����ٶȣ���λ��pulse /(ms*s) ��ȡֵ��Χ��0.001~8000.000
		*		 sine��		�������ߣ�0-T�ͣ�1-S��
		*		 out_bit��	�˶����յ����DOλ, ȡֵ��Χ��0-���DOλ��-1Ϊ��DO����	
		*		 out_data��	�˶����յ����DOֵ��ȡֵ��Χ��0-1
		*	     type��		�˶����� 0-ֱ�ߣ�1-Բ��
		*	     center_pos����άԲ��λ��
		*	     ccw_dir��	Բ������0-��ʱ�룬1-˳ʱ��
		*		 delaytime���յ���ͣʱ�䣬��λ��ms��0Ϊ����ʱ		
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Add_Mix_Segment(UInt32 card_no, UInt32 n_axis,  UInt32[] axislist,  int[] pos, float start_vel, float steady_vel, float end_vel, float acc, float dec, UInt32 sine, UInt32 type,  float[] center_pos, UInt32 ccw_dir);
		//********************************************************************************************************************************************************************
		/**
		* @brief д�뻺��������˶����ݣ��Զ��Ӽ��٣�
		* @param card_no��	�����Ŀ���
		*		 n_axis��	�˶�����������4�ᣩ	
		*		 p_axis��	�������	
		*		 pos��		����Ŀ��λ�����飬��λ pulse����Χ-2 31 ~2 31	
		*		 steady_vel��Ŀ���ٶȣ���λ��pulse /ms��ȡֵ��Χ��0.001~8000.000
		*		 acc��		Ŀ���(��)�ٶȣ���λ��pulse /(ms*ms) ��ȡֵ��Χ��0.001~8000.000
		*		 sine��		�������ߣ�0-T�ͣ�1-S��
		*		 out_bit��	�˶����յ����DOλ, ȡֵ��Χ��0-���DOλ��-1Ϊ��DO����	
		*		 out_data��	�˶����յ����DOֵ��ȡֵ��Χ��0-1
		*	     type��		�˶����� 0-ֱ�ߣ�1-Բ��
		*	     center_pos����άԲ��λ��
		*	     ccw_dir��	Բ������0-��ʱ�룬1-˳ʱ��
		*		 delaytime���յ���ͣʱ�䣬��λ��ms��0Ϊ����ʱ		
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Add_Mix_Seg(UInt32 card_no, UInt32 n_axis,  UInt32[] axislist,  int[] pos, float steady_vel, float acc, UInt32 sine, UInt32 type,  float[] center_pos, UInt32 ccw_dir);
		
		//********************************************************************************************************************************************************************
		/**
		* @brief �����岹�ȴ� IO ����
		* @param card_no��	�����Ŀ���	
		*		 in_bit��	����ںţ�ȡֵ��Χ��0~15
		*		 on_off��	��ͨ״̬��0������ͨ��1����ͨ
		*		 delaytime����ʱʱ�䣬��λ��ms
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Wait_Input(UInt32 card_no, UInt32 in_bit, UInt32 on_off, UInt32 delaytime);
		//********************************************************************************************************************************************************************
		/**
		* @brief �����岹������ڹ켣����� IO �ͺ����������ִ�У�
		* @param card_no��	�����Ŀ���	
		*		 out_bit��	����ںţ�ȡֵ��Χ��0~15
		*		 on_off��	��ͨ״̬��0������ͨ��1����ͨ
		*		 delay_value���ͺ�ֵ����λ��ms���ͺ�ʱ��ģʽ���� pulse���ͺ����ģʽ��
		*		 delay_mode���ͺ�ģʽ��0���ͺ�ʱ�䣬1���ͺ����
		*		 reverse_time����ƽ��������ʱ��תʱ�䣬��λ��ms
		* @return �ɹ�����0.
		* @remark ���õ� IO ���������ڸ�ָ�����һ���켣��������
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Delay_Outbit_To_Start(UInt32 card_no, UInt32 out_bit, UInt32 on_off, UInt32 delay_value, UInt32 delay_mode, UInt32 reverse_time);
		//********************************************************************************************************************************************************************
		/**
		* @brief �����岹������ڹ켣���յ� IO �ͺ����
		* @param card_no��	�����Ŀ���	
		*		 out_bit��	����ںţ�ȡֵ��Χ��0~15
		*		 on_off��	��ͨ״̬��0������ͨ��1����ͨ
		*		 delaytime���ͺ�ʱ��ֵ����λ��ms
		*		 reverse_time����ƽ��������ʱ��תʱ�䣬��λ��ms
		* @return �ɹ�����0.
		* @remark ���õ� IO ���������ڸ�ָ�����һ���켣��������
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Delay_Outbit_To_Stop(UInt32 card_no, UInt32 out_bit, UInt32 on_off, UInt32 delay_time, UInt32 reverse_time);
		//********************************************************************************************************************************************************************
		/**
		* @brief �����岹������ڹ켣���յ� IO ��ǰ���������ִ�У�
		* @param card_no��	�����Ŀ���	
		*		 out_bit��	����ںţ�ȡֵ��Χ��0~15
		*		 on_off��	��ͨ״̬��0������ͨ��1����ͨ
		*		 ahead_value����ǰֵ����λ��ms����ǰʱ��ģʽ���� pulse����ǰ����ģʽ��
		*		 ahead_mode����ǰģʽ��0����ǰʱ�䣬1����ǰ����
		*		 reverse_time����ƽ��������ʱ��תʱ�䣬��λ��ms
		* @return �ɹ�����0.
		* @remark ���õ� IO ���������ڸ�ָ�����һ���켣��������
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Ahead_Outbit_To_Stop(UInt32 card_no, UInt32 out_bit, UInt32 on_off, UInt32 ahead_value, UInt32 ahead_mode, UInt32 reverse_time);
		//********************************************************************************************************************************************************************
		/**
		* @brief �������δִ����� IO ����
		* @param card_no��	�����Ŀ���	
		*		 io_bit��	IO�ں�
		* @return �ɹ�����0.
		* @remark 
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Clear_Io_Action(UInt32 card_no, UInt32 io_bit);
		//********************************************************************************************************************************************************************
		/**
		* @brief �����岹����ͣ��ʱָ��
		* @param card_no��	�����Ŀ���	
		*		 delaytime: �յ���ͣʱ�䣬��λ��ms��0Ϊ������ʱ	
		* @return �ɹ�����0.
		* @remark 
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_delay(UInt32 card_no, int delaytime);

		//********************************************************************************************************************************************************************
		/**
		* @brief ���û������˶���λ������ʹ��
		* @param card_no��	�����Ŀ���
		*		 enable��	0-���ܣ�1-ʹ��	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Move_ListEn(UInt32 card_no, UInt32 en);

		//********************************************************************************************************************************************************************
		/**
		* @brief ��ջ������˶���λ������
		* @param 
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Move_ListClear(UInt32 card_no);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�������˶���λ������ָ������
		* @param space��	����PC����������ָ��ȴ����أ�����

		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Buff_Move_ListSpace(UInt32 card_no, ref UInt32 space);

		/**********************************************************************************
		* @End �������˶�
		***********************************************************************************/
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ÿ�����IP��ַ��Ĭ�ϵ�ַΪ192.168.100.1��
		* @param card_no��	0
		*		 IP_1��	IP��ַ��һλ����ӦĬ�ϵ�ַΪ192
		*		 IP_2��	IP��ַ�ڶ�λ����ӦĬ�ϵ�ַΪ168
		*		 IP_3��	IP��ַ����λ����ӦĬ�ϵ�ַΪ100
		*		 IP_4��	IP��ַ����λ����ӦĬ�ϵ�ַΪ1
		* @return �ɹ�����0.
		* @remark ����ģʽʱ��������������ͨѶ���ڹ�����������
		*/
		[DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_IP(UInt32 card_no, UInt32 IP_1 , UInt32 IP_2 , UInt32 IP_3 , UInt32 IP_4 );
		//********************************************************************************************************************************************************************
		/**********************************************************************************
		* @Begin IO����
		***********************************************************************************/

		//********************************************************************************************************************************************************************
		/**
		* @brief ��λ�������DOλ��״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	���λ�����ţ���Χ0~63
		*		 data��		IO�����״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_OutBit(UInt32 card_no, UInt32 addr, UInt32 index, UInt32 data);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��λ��ȡIO�����״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	���λ�����ţ���Χ0~63
		*		 data��		IO�����״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_OutBit(UInt32 card_no, UInt32 addr, UInt32 index, ref UInt32 data);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��λ��ȡIO�����״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	����λ�����ţ���Χ0~63
		*		 data��		IO�����״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_InBit(UInt32 card_no, UInt32 addr, UInt32 index, ref UInt32 data);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ֽ��������DOλ��״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	���λ�����ţ���Χ0~7
		*		 data��		IO���ֽ������״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_OutByte(UInt32 card_no, UInt32 addr, UInt32 index, UInt32 data);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ֽڶ�ȡ��վ��IO����״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	DI�����ţ���Χ��0~7
		*		 data��		IO�����״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_InByte(UInt32 card_no, UInt32 addr, UInt32 index, ref UInt32 data);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ֽڶ�ȡIO�����״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	���λ�����ţ���Χ0~7
		*		 data��		IO�����״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_OutByte(UInt32 card_no, UInt32 addr, UInt32 index, ref UInt32 data);

		//********************************************************************************************************************************************************************
		/**
		* @brief �����������DOλ��״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	���λ�����ţ���Χ0~3
		*		 data��		IO���������״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_OutWord(UInt32 card_no, UInt32 addr, UInt32 index, UInt32 data);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��˫���������DOλ��״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	���λ�����ţ���Χ0~1
		*		 data��		IO��˫�������״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_OutDWord(UInt32 card_no, UInt32 addr, UInt32 index, UInt32 data);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ֶ�ȡIO�����״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	���λ�����ţ���Χ0~3
		*		 data��		IO�����״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Get_OutWord(UInt32 card_no, UInt32 addr, UInt32 index, ref UInt32 data);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��˫�ֶ�ȡIO�����״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	���λ�����ţ���Χ0~1
		*		 data��		IO�����״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_OutDWord(UInt32 card_no, UInt32 addr, UInt32 index, ref UInt32 data);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���ֶ�ȡ��վ��IO����״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	DI�����ţ���Χ��0~3
		*		 data��		IO�����״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_InWord(UInt32 card_no, UInt32 addr, UInt32 index, ref UInt32 data);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��˫�ֶ�ȡ��վ��IO����״̬
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	DI�����ţ���Χ��0~1
		*		 data��		IO�����״̬��0-����ͨ��1-��ͨ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_InDWord(UInt32 card_no, UInt32 addr, UInt32 index, ref UInt32 data);

		//********************************************************************************************************************************************************************
		/**
		* @brief ע����Ӧ�����źŵĻص�����(IO�жϹ���)
		* @param card_no��	�����Ŀ���
		*		 fn��		�ص�����ָ��
		*		 addr��		�ӿ��ţ�����Ϊ0
		*		 in_bit��	DI�����ֽڵ�λ����
		*		 edge��		�źű��أ�0-�½��أ�1-������
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Register_Callback(UInt32 card_no, sldmv.fn cbEvent, UInt32 addr, UInt32 in_bit, UInt32 edge);
		//********************************************************************************************************************************************************************
        /**
        * @brief ȡ����Ӧ�����źŵĻص�����
        * @param card_no��	�����Ŀ���
        *		 addr��		�ӿ��ţ�����Ϊ0
        *		 in_bit��	DI�����ֽڵ�λ����
        *		 edge��		�źű��أ�0-�½��أ�1-������
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Unregister_Callback(UInt32 card_no, UInt32 addr, UInt32 in_bit, UInt32 edge);

		//********************************************************************************************************************************************************************
		/**
		* @brief ��λ����IO �����ʱ��ת
		* @param card_no��	�����Ŀ���
		*		 addr��		�ӿ��ţ�����Ϊ0	
		*		 index��	���λ�����ţ���Χ0~63
		*		 data��		IO�����״̬��0-����ͨ��1-��ͨ
		*		 reverse_time����ת��ʱʱ��(��λ��ms)��0-����ת,ȡֵ��Χ(0-42949672)ms
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Reverse_OutBit(UInt32 card_no, UInt32 addr, UInt32 index, UInt32 data, UInt32 reverse_time);
        //********************************************************************************************************************************************************************
        /**
        * @brief ��λ����IO ��ʱ�����ʱ��ת
        * @param card_no��	�����Ŀ���
        *		 addr��		�ӿ��ţ�����Ϊ0	
        *		 index��	���λ�����ţ���Χ0~63
        *		 data��		IO�����״̬��0-����ͨ��1-��ͨ
        *		 delay_time����ʱ���ʱ��(��λ��ms)��0-����ʱ
        *		 reverse_time����ת��ʱʱ��(��λ��ms)��0-����ת
        * @return �ɹ�����0.//
        * @remark
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Toggle_OutBit(UInt32 card_no, UInt32 addr, UInt32 index, UInt32 data, UInt32 delay_time, UInt32 reverse_time);
		/**********************************************************************************
		* @End IO����
		***********************************************************************************/






		/********************************************************************************
		* @Begin λ�ñȽ�
		*******************************************************************************/

		//********************************************************************************************************************************************************************
		/**
		* @brief λ�ñȽ�ʹ��
		* @param card_no��	�����Ŀ���
		*		 fifo��		λ�ñȽ���ѡ��(0-1)		
		*		 en��		ʹ��,0-��ʹ�ܣ�1-ʹ��	
		* @return �ɹ�����0.
		* @remark 
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Cmpr_Enable(UInt32 card_no, UInt32 fifo, UInt32 en);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ������λ�ñȽ�ʹ��״̬
		* @param card_no��	�����Ŀ���
		*		 fifo��		λ�ñȽ���ѡ��(0-1)	
		*		 en��		λ�ñȽ�ʹ��״̬��0-��ʹ�ܣ�1-ʹ��
		* @return �ɹ�����0.
		* @remark 
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Cmpr_Enable(UInt32 card_no, UInt32 fifo, ref UInt32 en);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���λ�ñȽ�����
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��	
		*		 cmpr_pos��	�Ƚ�λ��
		*		 fifo��		λ�ñȽ����ţ���Ӧ���DO��λ ��0-1��
		*		 width��	λ�ñȽ���������ȣ���λ10us
		*		 out_level���Ƚϳɹ�ʱDO�����״̬��0-����ͨ��1-��ͨ
		*		 src��		λ�ñȽ�λ��Դ��0-����λ�ã�1-������λ�á�
		* @return �ɹ�����0.
		* @remark 
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Cmpr_Add_Point(UInt32 card_no, UInt32 axis, int cmpr_pos, UInt32 fifo, UInt32 width, UInt32 out_level, UInt32 src);
		//********************************************************************************************************************************************************************
		/**
		* @brief �õ�λ�ñȽ�λ�û�����״̬
		* @param card_no��	�����Ŀ���
		*		 fifo��		λ�ñȽ���ѡ��(0-1)		
		*		 space��	������ʣ�������������256λ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Cmpr_Fifo_Space(UInt32 card_no, UInt32 fifo, ref UInt32 space);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���λ�ñȽ�λ�û����������Ƚ���ɸ���
		* @param card_no��	�����Ŀ���
		*		 fifo��		λ�ñȽ���ѡ��(0-1)	
		*		 fifo_data_en��	λ�ñȽϻ����������0-�������1-���	
		*		 complete_num_en��	λ�ñȽ���ɸ��������0-�������1-���
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Clear_Cmpr(UInt32 card_no, UInt32 fifo, UInt32 fifo_data_en, UInt32 complete_num_en);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ʼλ�ñȽ�
		* @param card_no��	�����Ŀ���
		*		 fifo��		λ�ñȽ���ѡ��(0-1)	
		*		 start��	��ʼ��0-ֹͣ��1-��ʼ	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Start_Cmpr(UInt32 card_no, UInt32 fifo, UInt32 start);
		//********************************************************************************************************************************************************************
		/**
		* @brief �õ�λ�ñȽ���ɸ���
		* @param card_no��	�����Ŀ���
		*		 fifo��		λ�ñȽ���ѡ��(0-1)		
		*		 num��		����λ�ñȽ���ɸ���
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Cmpr_Num(UInt32 card_no, UInt32 fifo, ref UInt32 num);
		//********************************************************************************************************************************************************************
		/**
		* @brief �����ȼ��λ�ñȽ�
		* @param card_no��	�����Ŀ���
		*		 axis��		��ѡ��0-4	
		*		 startPos��	��ʼλ�ñȽ�λ��
		*		 interval��	�Ƚ�λ�ü��
		*		 fifo��	λ�ñȽ����ţ���Ӧ���DO��λ ��0-1��
		*		 width��	λ�ñȽ���������ȣ���λ10us
		*		 out_level���Ƚϳɹ�ʱDO�����״̬��0-����ͨ��1-��ͨ
		*		 src��		λ�ñȽ�λ��Դ��0-����λ�ã�1-������λ�á�
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Compare_Linear(UInt32 card_no, UInt32 axis, int startPos, int interval, UInt32 fifo, UInt32 width, UInt32 out_level, UInt32 src);
		//********************************************************************************************************************************************************************
		/**
		* @brief ����λ�ñȽ�ģʽ
		* @param card_no��	�����Ŀ���
		*		 fifo��		λ�ñȽ���ѡ��(0-1)		
		*		 mod��		λ�ñȽ�ģʽ��0��һάλ�ñȽϣ�1���ȼ��λ�ñȽϣ�2����άλ�ñȽ�
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Cmpr_Mod(UInt32 card_no, UInt32 fifo, UInt32 mod);
        //********************************************************************************************************************************************************************
        /**
        * @brief ��άλ�ñȽ����λ�ñȽ�����
        * @param card_no��	�����Ŀ���
        *		 axislist��	��ά��ѡ���б�	
        *		 cmpr_pos��	��ά�Ƚ�λ���б�
        *		 max_err��	�Ƚ�λ�õ�λ�����������ȡֵ��Χ[0,512)����λ��pulse
        *		 threshould�������㷨��ֵ
        *		 fifo��		λ�ñȽ����ţ���Ӧ���DO��λ ��0-1��
        *		 width��	λ�ñȽ���������ȣ���λ10us
        *		 out_level���Ƚϳɹ�ʱDO�����״̬��0-����ͨ��1-��ͨ
        *		 src��		λ�ñȽ�λ��Դ��0-����λ�ã�1-������λ�á�
        * @return �ɹ�����0.
        * @remark 
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Cmpr_2D(UInt32 card_no, UInt32[] axislist, Int32[] cmpr_pos, UInt32 max_err, UInt32 threshould, UInt32 fifo, UInt32 width, UInt32 out_level, UInt32 src);
        //********************************************************************************************************************************************************************
        /**
        * @brief ��άλ�ñȽ����λ�ñȽ�����
        * @param card_no��	�����Ŀ���
        *		 axislist��	��ά��ѡ���б�	
        *		 cmpr_pos��	��ά�Ƚ�λ���б�
        *		 max_err��	�Ƚ�λ�õ�λ�����������ȡֵ��Χ[0,512)����λ��pulse
        *		 threshould�������㷨��ֵ
        *		 fifo��		λ�ñȽ����ţ���Ӧ���DO��λ ��0-1��
        *		 width��	λ�ñȽ���������ȣ���λ10us
        *		 out_level���Ƚϳɹ�ʱDO�����״̬��0-����ͨ��1-��ͨ
        *		 src��		λ�ñȽ�λ��Դ��0-����λ�ã�1-������λ�á�
        * @return �ɹ�����0.
        * @remark 
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Cmpr_3D(UInt32 card_no, UInt32[] axislist, Int32[] cmpr_pos, UInt32 max_err, UInt32 threshould, UInt32 fifo, UInt32 width, UInt32 out_level, UInt32 src);

		/**********************************************************************************
		* @End λ�ñȽ�
		***********************************************************************************/


		/**********************************************************************************
		* @Begin λ������
		***********************************************************************************/


		//********************************************************************************************************************************************************************
		/**
		* @brief ��ʼλ������
		* @param card_no��	�����Ŀ���
		*		 fifo��		λ��������ѡ��(0-1)
		*		 start��	1-��������,0-ֹͣ����
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Start_Latch(UInt32 card_no, UInt32 fifo, UInt32 start);
		//********************************************************************************************************************************************************************
		/**
		* @brief ����λ���������
		* @param card_no��	�����Ŀ���
		*		 fifo��		λ�����滺����ѡ�񣬣�λ�����滺����= DI�ںţ�0-1	
		*		 axis��	��ѡ�� 0-7
		*		 src��		λ������λ��Դѡ��0-ָ��λ�ã�1-������λ��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_Latch_Para(UInt32 card_no, UInt32 fifo, UInt32 axis, UInt32 src);//,ushort trigger);
																										//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡλ����������
		* @param card_no��	�����Ŀ���
		*		 fifo��		λ�����滺����ѡ�񣬣�λ�����滺����= DI�ںţ�0-1	
		*		 pos��		����λ��
		*		 pos_delay����������ڵ�ƽ��Чʱ��
		*		 numofcapt��λ��������ɸ���
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Latch_Pos(UInt32 card_no, UInt32 fifo, int[] pos, [Out] UInt32[] pos_delay, ref UInt32 numofcapt);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡλ����������
		* @param card_no��	�����Ŀ���
		*		 fifo��		λ��������ѡ��(0-1)	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Clear_Latch_Fifo(UInt32 card_no, UInt32 fifo);
        /**
        * @brief ע��λ������ص�����
        * @param card_no��	�����Ŀ���
        *		 fn��		�ص�����	
        *		 fifo��		λ��������ѡ��(0-1)
        *		 hold_time����������ڵ�ƽ��Чʱ��
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern long SLDM_Register_Latch_Callback(UInt32 card_no, sldmv.fn cbEvent, UInt32 fifo, UInt32 hold_time);
        /**
        * @brief ע��λ������ص�����
        * @param card_no��	�����Ŀ���
        *		 fifo��		λ��������ѡ��(0-1)
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern long SLDM_Unregister_Latch_Callback(UInt32 card_no, UInt32 fifo);

		/**********************************************************************************
		* @End λ������
		***********************************************************************************/

		/**********************************************************************************
		* @Begin PT�˶�
		***********************************************************************************/

		//********************************************************************************************************************************************************************
		/**
		* @brief ��λPT�˶���PTģʽ��ʼ���˳�ʱ����
		* @param card_no��	�����Ŀ���	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PtInit(UInt32 card_no);
		//********************************************************************************************************************************************************************
		/**
		* @brief ����ָ����Ϊ PT �˶�ģʽ
		* @param card_no��	�����Ŀ���	
		*		 axis��		��ѡ��(0-3)	
		*		 mode��		PT_MODE_STATIC��̬ģʽ��PT_MODE_DYNAMIC ��̬ģʽ	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PrfPt(UInt32 card_no, UInt32 axis, UInt32 mode = 0);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ѯ PT �˶�ģʽָ�� FIFO ��ʣ��ռ�
		* @param card_no��	�����Ŀ���	
		*		 axis��		��ѡ��(0-3)	
		*		 pspace��	����Fifo�Ŷ�Ӧʣ��ռ䣬��̬ģʽʱ������ʣ��ռ�
		*		 fifo��		Fifo��(0-1)	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PtSpace(UInt32 card_no, UInt32 axis, ref UInt32 pspace, UInt32 fifo = 0);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���� PT �˶�
		* @param card_no��	�����Ŀ���	
		*		 axis��		��ѡ��(0-3)	
		*		 start��	1-������Ӧ���ᣬ0-ֹͣ��Ӧ����	
		*		 option��	λ�����ʾ����ʹ�õ� FIFO,Ĭ��Ϊ 0,��̬ģʽ�¸ò�����Ч.
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PtStart(UInt32 card_no, UInt32 axis, UInt32 start, UInt32 option);
		//********************************************************************************************************************************************************************
		/**
		* @brief �� PT �˶�ģʽָ�� FIFO ��������
		* @param card_no��	�����Ŀ���	
		*		 axis��		���
		*		 pos��		λ��
		*		 time��		ʱ�䣬��λ����
		*		 type��		�˶����ͣ�0-��ͨ�Σ�1-���ٶΣ�2-���ٶ�
		*		 fifo��		Fifo��
		*		 move_delay���˶�������ֹͣ��ʱʱ��
		*		 out_bit��	�˶����������DOλ��-1�����
		*		 out_data��	�˶����������DOλ״̬��0-����ͨ��1-��ͨ
		*		 out_delay�����DOλ��ʱʱ��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PtData(UInt32 card_no, UInt32 axis, int pos, UInt32 time, UInt32 type, UInt32 fifo = 0, UInt32 move_delay = 0, int out_bit = -1, UInt32 out_data = 0, UInt32 out_delay = 0);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��� PT �˶�ģʽָ�� FIFO �е�����
		* @param card_no��	�����Ŀ���	
		*		 axis��		��ѡ��(0-3)		
		*		 fifo��		Fifo��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PtClear(UInt32 card_no, UInt32 axis, UInt32 fifo);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���� PT �˶�ģʽѭ��ִ�еĴ�������̬ģʽ�¸�ָ����Ч
		* @param card_no��	�����Ŀ���	
		*		 axis��		��ѡ��(0-3)		
		*		 loop��		ѭ��������0-����ѭ��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_SetPtLoop(UInt32 card_no, UInt32 axis, UInt32 loop);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ѯ PT �˶�ģʽѭ��ִ�еĴ�������̬ģʽ�¸�ָ����Ч
		* @param card_no��	�����Ŀ���	
		*		 axis��		��ѡ��(0-3)		
		*		 ploop��	����ѭ������
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_GetPtLoop(UInt32 card_no, UInt32 axis, ref UInt32 ploop);
		//********************************************************************************************************************************************************************
		/**
		* @brief ���� PT �˶�ģʽ�Ļ�����(FIFO)��С
		* @param card_no��	�����Ŀ���	
		*		 memory��	���100	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_SetPtMemory(UInt32 card_no, UInt32 memory);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ PT �˶�ģʽ�Ļ�������С
		* @param card_no��	�����Ŀ���	
		*		 pmemory��	���ػ�������С
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_GetPtMemory(UInt32 card_no, ref UInt32 pmemory);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ PT �˶�ģʽ�Ļ������˶�ָ��
		* @param card_no��	�����Ŀ���	
		*		 axis��		��ѡ��(0-3)	
		*		 move_p��	���ػ������˶�ָ��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_GetPtMoveP(UInt32 card_no, UInt32 axis, ref UInt32 move_p);

		//********************************************************************************************************************************************************************
		/**
		* @brief ����PT�˶���λ������ʹ��
		* @param card_no��	�����Ŀ���
		*		 enable��	0-���ܣ�1-ʹ��	
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Pt_ListEn(UInt32 card_no, UInt32 en);

		//********************************************************************************************************************************************************************
		/**
		* @brief ���PT�˶���λ������
		* @param card_no��	�����Ŀ���
				 axis��		���
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Pt_ListClear(UInt32 card_no, UInt32 axis);

		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡPT�˶���λ������ָ������
		* @param card_no��	�����Ŀ���
				 space��	����PC����������ָ��ȴ����أ�����
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Pt_ListSpace(UInt32 card_no, ref UInt32 space);



		/**********************************************************************************
		* @End PT�˶�
		***********************************************************************************/

		/**********************************************************************************
		* @Begin PWM����
		***********************************************************************************/


		//********************************************************************************************************************************************************************
		/**
		* @brief ����PWM����ʹ��
		* @param card_no��	�����Ŀ���	
		*		 pwm��		PWMģ���(0-1)
		*		 en��		PWMģ��ʹ�ܣ�1-ʹ�ܣ�0-��ֹ��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_PWM_Enable(UInt32 card_no, UInt32 pwm, UInt32 en);
		//********************************************************************************************************************************************************************
		/**
		* @brief ����PWM���ܿ�ʼ
		* @param card_no��	�����Ŀ���	
		*		 pwm��		PWMģ���(0-1)
		*		 start��	1-��ʼ��0-ֹͣ
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PWM_Start(UInt32 card_no, UInt32 pwm, UInt32 start);
		//********************************************************************************************************************************************************************
		/**
		* @brief ����PWM���ܲ���
		* @param card_no��	�����Ŀ���	
		*		 pwm��		PWMģ���
		*		 duty��		PWMռ�ձ� 0-1
		*		 fre��		PWMƵ��
		*		 pol��		PWM����
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_PWM_Config(UInt32 card_no, UInt32 pwm, float duty, float fre, UInt32 pol);
		//********************************************************************************************************************************************************************
		/**
		* @brief ����PWM����ʹ��
		* @param card_no��	�����Ŀ���	
		*		 pwm��		PWMģ���
		*		 duty��		����PWMռ�ձ�
		*		 fre��		����PWMƵ��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_PWM(UInt32 card_no, UInt32 pwm, ref float duty, ref float fre);

		//********************************************************************************************************************************************************************
		/**
		* @brief ��ʹ�ø���ģʽ�������岹�� PWM ������ã����PWM�Ѿ��򿪣�PWM ���Ƶ�ʼ�ռ�ձ������ı�
		* @param card_no��	�����Ŀ���	
		*		 pwm��		PWMģ��� 0-1
		*		 fDuty��	PWMռ�ձ� 0-1
		*		 fFre��		PWMƵ��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Set_PWM_Output(UInt32 card_no, UInt32 pwm, float fDuty, float fFre);
		//�� �ܣ����� PWM ����״̬��Ӧ��ռ�ձ�,����4����������ʹ�ã�����ģʽ0-4
		//********************************************************************************************************************************************************************
		/**
		* @brief ʹ�ø���ģʽ������ PWM ����״̬��Ӧ��ռ�ձ�
		* @param card_no��	�����Ŀ���	
		*		 pwm��		PWMģ���
		*		 fOnDuty��	PWM ��״̬��ռ�ձȣ�ȡֵ��Χ��0~1
		*		 fOffDuty��	PWM �ر�״̬��ռ�ձȣ�ȡֵ��Χ��0~1
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Set_PWM_Onoff_Duty(UInt32 card_no, UInt32 pwm, float fOnDuty, float fOffDuty);

		//********************************************************************************************************************************************************************
		/**
		* @brief ʹ�ø���ģʽ�������岹�� PWM �ٶȸ�������
		* @param card_no��	�����Ŀ���	
		*		 pwm��		PWMģ��ţ�ȡֵ��Χ��0~1
		*		 mode��		����ģʽ��
							0�������棬����״̬
							1�������棬����͵�ƽ
							2�������棬����ߵ�ƽ
							3�����棬ռ�ձ��Զ�����
							4�����棬Ƶ���Զ�����
		*		 maxVel��	��������ٶȣ���λ��pulse /ms
		*		 maxValue��	������ֵ��
							����ģʽΪ 3 ʱ��ռ�ձȣ�ȡֵ��Χ��0~1
							����ģʽΪ 4 ʱ��Ƶ�ʣ�ȡֵ��Χ��0~2MHz
		*		 outValue��	�̶����ֵ��
							����ģʽΪ 3 ʱ��Ƶ�ʣ�ȡֵ��Χ��0~2MHz
							����ģʽΪ 4 ʱ��ռ�ձȣ�ȡֵ��Χ��0~1
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Set_PWM_Follow_Speed(UInt32 card_no, UInt32 pwm, UInt32 mode, float maxVel, float maxValue, float outValue);

		//********************************************************************************************************************************************************************
		/**
		* @brief �����岹������ڹ켣����� PWM �ͺ����������ִ�У�
		* @param card_no��		�����Ŀ���	
		*		 pwm��			PWMģ��ţ�ȡֵ��Χ��0~1
		*		 on_off��		���״̬��0���رգ�1����
		*		 delay_value��	�ͺ�ֵ����λ��ms���ͺ�ʱ��ģʽ���� pulse���ͺ����ģʽ��
		*		 delay_mode��	�ͺ�ģʽ��0���ͺ�ʱ�䣬1���ͺ����
		*		 reverse_time��	�����������̶�ֵΪ 0
		* @return �ɹ�����0.
		* @remark ���õ� IO ���������ڸ�ָ�����һ���켣��������
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Delay_PWM_To_Start(UInt32 card_no, UInt32 pwm, UInt32 on_off, UInt32 delay_value, UInt32 delay_mode, float reverse_time);

		//********************************************************************************************************************************************************************
		/**
		* @brief �����岹������ڹ켣���յ� PWM ��ǰ���������ִ�У�
		* @param card_no��		�����Ŀ���	
		*		 pwm��			PWMģ��ţ�ȡֵ��Χ��0~1
		*		 on_off��		���״̬��0���رգ�1����
		*		 ahead_value��	��ǰֵ����λ��ms����ǰʱ��ģʽ���� pulse����ǰ����ģʽ��
		*		 ahead_mode��	��ǰģʽ��0����ǰʱ�䣬1����ǰ����
		*		 reverse_time��	�����������̶�ֵΪ 0
		* @return �ɹ�����0.
		* @remark ���õ� IO ���������ڸ�ָ�����һ���켣��������
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Buff_Ahead_PWM_To_Stop(UInt32 card_no, UInt32 pwm, UInt32 on_off, UInt32 ahead_value, UInt32 ahead_mode, float reverse_time);



		/**********************************************************************************
		* @End PWM����
		***********************************************************************************/


		/**********************************************************************************
		* @Begin ��������������
		***********************************************************************************/
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�������Ĳ�Ʒ�汾��
		* @param card_no��	�����Ŀ���
		*		 softver��	���������汾��
		*		 fpgaver��	����Ӳ���汾��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_SysVersion(UInt32 card_no, ref UInt32 softver, ref UInt32 fpgaver);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ��������ARM���к�
		* @param card_no��	�����Ŀ���
		*		 id��		���ؿ�������ARM���к�(12byte) 
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_ArmID(UInt32 card_no, ref UInt32 id);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�������Ĳ�Ʒ���к�
		* @param card_no��	�����Ŀ���
		*		 id��		���ؿ������Ĳ�Ʒ���к�(4byte)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_CardID(UInt32 card_no, ref UInt32 id);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ�������Ĳ�Ʒ��Ϣ
		* @param card_no��	�����Ŀ���
		*		 card_info�����ؿ������Ĳ�Ʒ��Ϣ�ṹ��
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_CardInfo(UInt32 card_no, ref CARD_INFO card_info);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ������IO��������
		* @param card_no��	�����Ŀ���
		*		 axis_num��	���ؿ�������(Ĭ��4)
		*		 di_num��	������������˿�����(Ĭ��16)
		*		 do_num��	������������˿�����(Ĭ��16)
		*		 ad_num��	����ģ��������˿�����(Ĭ��0)
		*		 da_num��	����ģ��������˿�����(Ĭ��0)
		*		 pwm_num��	����PWM�˿�����(Ĭ��2)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Card_IOResource(UInt32 card_no, ref UInt32 axis_num, ref UInt32 di_num, ref UInt32 do_num, ref UInt32 ad_num, ref UInt32 da_num, ref UInt32 pwm_num);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ������λ�ñȽ����湦��ģ����������
		* @param card_no��	�����Ŀ���
		*		 cmpr1_num��	����һάλ�ñȽ�������(Ĭ��2)
		*		 cmprline_num��	��������λ�ñȽ�������(Ĭ��2)
		*		 cmpr2_num��	���ض�άλ�ñȽ�������(Ĭ��0)
		*		 latch_num��	����λ������������(Ĭ��2)
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Card_EXResource(UInt32 card_no, ref UInt32 cmpr1_num, ref UInt32 cmprline_num, ref UInt32 cmpr2_num, ref UInt32 latch_num);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��ȡ������ģʽ����
		* @param card_no��	�����Ŀ���
		*		 model��	���ؿ�����ģʽ
		*		 type��		���ؿ���������
		*		 period��	���ؿ������ŷ�����
		* @return �ɹ�����0.
		* @remark
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Card_Model(UInt32 card_no, ref UInt32 model, ref UInt32 type, ref UInt32 period);


		//********************************************************************************************************************************************************************
		/**
		* @brief �û���Ʒע����д��
		* @param card_no��	�����Ŀ���
		*		 reg_code��	�ͻ�ע����
		*		 reg_code_md5������д���������MD5�� ��16byte��
		* @return �ɹ�����0.
		* @remark (EEPROM��С��20*32bit)
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Write_Regcode(UInt32 card_no,  byte[] reg_code, ref byte reg_code_md5);
		//********************************************************************************************************************************************************************
		/**
		* @brief ����д���������MD5��
		* @param card_no��	�����Ŀ���
		*		 reg_code��	����д���������MD5�루16byte��
		* @return �ɹ�����0.
		* @remark (EEPROM��С��20*32bit)
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Read_Regcode(UInt32 card_no, ref byte reg_code);
		//********************************************************************************************************************************************************************
		/**
		* @brief EEPROM����д�� 
		* @param card_no��	�����Ŀ���
		*		 addr��		д���ַ,��Χ��0-20
		*		 num��		д�����0-20
		*		 pData��	д������,��Χ��32bit
		* @return �ɹ�����0.
		* @remark (EEPROM��С��20*32bit)
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_E2prom_Write(UInt32 card_no, UInt32 addr, UInt32 num,  uint[] pData);
		//********************************************************************************************************************************************************************
		/**
		* @brief EEPROM���ݶ��� 
		* @param card_no��	�����Ŀ���
		*		 addr��		������ַ,��Χ��0-20
		*		 num��		��������0-20
		*		 pData��	��������,��Χ��32bit
		* @return �ɹ�����0.
		* @remark (EEPROM��С��20*32bit)
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_E2prom_Read(UInt32 card_no, UInt32 addr, UInt32 num, ref int pData);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��չEEPROM����д�� 
		* @param card_no��	�����Ŀ���
		*		 addr��		д���ַ,��Χ��0-20
		*		 num��		д�����0-20
		*		 pData��	д������,��Χ��32bit
		* @return �ɹ�����0.
		* @remark (EEPROM��С��20*32bit)
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_ExE2prom_Write(UInt32 card_no, UInt32 addr, UInt32 num,  int[] pData);
		//********************************************************************************************************************************************************************
		/**
		* @brief ��չEEPROM���ݶ��� 
		* @param card_no��	�����Ŀ���
		*		 addr��		������ַ,��Χ��0-20
		*		 num��		��������0-20
		*		 pData��	��������,��Χ��32bit
		* @return �ɹ�����0.
		* @remark (EEPROM��С��20*32bit)
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_ExE2prom_Read(UInt32 card_no, UInt32 addr, UInt32 num, ref int pData);

		//********************************************************************************************************************************************************************
		/**
		* @brief װ��ϵͳ�����ļ������ص������� 
		* @param card_no��	�����Ŀ���
		* @return �ɹ�����0.
		* @remark �����ļ���E450config.ini
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Load_ParaFile(UInt32 card_no);
		//public static extern int SLDM_LoadParaFile(UInt32 card_no,Home_Para *homepara);
		//********************************************************************************************************************************************************************
		/**
		* @brief ����ϵͳ�����ļ�
		* @param card_no��	�����Ŀ���
		* @return �ɹ�����0.
		* @remark �����ļ���E450config.ini
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Save_ParaFile(UInt32 card_no);


		/**********************************************************************************
		* @End ��������������
		***********************************************************************************/

        /**********************************************************************************
         * @Begin ETHERCAT����
         ***********************************************************************************/


        //********************************************************************************************************************************************************************
        /**
        * @brief ����ethercat�����������������ͺ�
        * @param card_no��	�����Ŀ���
        *		 axisnum��	��������������
        *		 type��		�������������ͺ��б�����
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Set_Ecat_Axis(UInt32 card_no, UInt32 axis_num, UInt32[] type);

        //********************************************************************************************************************************************************************
        /**
        * @brief ethercat��������λ
        * @param card_no��	�����Ŀ���
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Ecat_Reset(UInt32 card_no);


        //********************************************************************************************************************************************************************
        /**
        * @brief ��ȡethercat������������״̬
        * @param card_no��	�����Ŀ���
        *		 cur_axisnum��		��ǰ���������
        *		 online_flag��		λ�����ʾ�������߱�־ 0-���� 1-����
        *		 link_ok��			���ʼ��������ɱ�־ 0-δ��� 1-���
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Get_Ecat_Status(UInt32 card_no, ref UInt32 cur_axisnum, ref UInt32 online_flag, ref UInt32 link_ok);

        //********************************************************************************************************************************************************************
        /**
        * @brief ��ȡethercat������������Z�ź�����λ��
        * @param card_no��	�����Ŀ���
        *		 axis��		���
        *		 pos��		���صĶ�Ӧ������Z�ź�����λ�ü���ֵ
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Get_Ecat_ZCap_pos(UInt32 card_no, UInt32 axis, ref int pos);

        //********************************************************************************************************************************************************************
        /**
        * @brief ��ȡethercat��������Ȩ��������
        * @param card_no��	�����Ŀ���
        *		 axisnum��	���ؿ�������Ȩ��������
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Get_Ecat_Release_AxisNum(UInt32 card_no, ref UInt32 axisnum);

        //********************************************************************************************************************************************************************
        /**
        * @brief ��ȡethercat��������չ������λ��
        * @param card_no��	�����Ŀ���
        *		 exenc_num����չ�������ţ���ethercat��������������Ż����ϵ���
        *		 pos��		���صĶ�Ӧ����������ֵ
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Get_EcatEx_Enc(UInt32 card_no, UInt32 exenc_num, ref int pos);


        /**********************************************************************************
        * @End ETHERCAT����
        ***********************************************************************************/

        /**********************************************************************************
        * @Begin ���ֹ���
        ***********************************************************************************/
        //********************************************************************************************************************************************************************
        /**
        * @brief ���������˶�����
        * @param card_no��	�����Ŀ���
        *		 axis_num��	���ֿ�������
        *		 axis_list��������ѡ��λ��Ӧ�������б�����
        *		 mult_list�����ֱ���ѡ��λ��Ӧ���Ʊ����б�����
        *		 dir_pol��	�����ԡ���0-����1-����	
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Set_HandWheel_Config(UInt32 card_no, UInt32 axis_num, UInt32[] axis_list, UInt32[] mult_list, UInt32 dir_pol);
        //********************************************************************************************************************************************************************
        /**
        * @brief ���������˶�����ٶȺͼ��ٶ�
        * @param card_no��	�����Ŀ���
        *		 max_vel��	����ٶȣ���λ��p/ms
        *		 max_acc��	�����ٶȣ���λ��p/(ms*ms)	
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Set_HandWheel_MaxVel(UInt32 card_no, UInt32 max_vel, UInt32 max_acc);
        //********************************************************************************************************************************************************************
        /**
        * @brief ���������˶�ʹ��
        * @param card_no��	�����Ŀ���
        *		 enable��	ʹ�ܣ�0-��ʹ�ܣ�1-ʹ��	
        * @return �ɹ�����0.
        * @remark
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Set_HandWheel_Enable(UInt32 card_no, UInt32 enable);
        //********************************************************************************************************************************************************************
        /**
        * @brief ��ȡ��������˿�״̬
        * @param card_no��	�����Ŀ���
        *		 di_status��XYZ45��X10X100�˿ڵ�ƽ״̬
        *					bit:
        *					0��X
        *					1��Y
        *					2��Z
        *					3��4
        *					4��5
        *					5��X10
        *					6��X100
        *					7��0
        *		 enc_data��	���ֱ���������ֵ

        * @return �ɹ�����0.
        * @remark �����ļ���E450config.ini
        */
        [DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SLDM_Get_HandWheel_Status(UInt32 card_no, ref UInt32 di_status, ref int enc_data);
        /**********************************************************************************
        * @End ���ֹ���
        ***********************************************************************************/



		/**********************************************************************************
		* @Begin �������Ժ���
		***********************************************************************************/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Recbuf(UInt32 card_no, ref string recbuf, ref string recbuf_ID, ref string recbuf_EEP, ref string recbuf_SELF, ref string recbuf_ERR);
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Sendbuf(UInt32 card_no, ref string sendbuf);
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Set_commthread_debug(UInt32 card_no, short debug_mode, short debug_key);
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Test_function(UInt32 card_no, UInt32 para_num);//����UDP����
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_CommTime(ref float cur_time, ref float max_time);
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_CommTime_10000(ref float time);
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_udp_complete_num(ref int write_num, ref int read_num);
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Get_Home_flag(UInt32 card_no, UInt32 axis, ref int flag);
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Cmpr_2D(UInt32 card_no, ref UInt32 axislist, ref int cmpr_pos, UInt32 max_err, UInt32 threshould, UInt32 fifo, UInt32 width, UInt32 out_level, UInt32 src);

		/**********************************************************************************
		* @End �������Ժ���
		***********************************************************************************/

		//********************************************************************************************************************************************************************
		/**
		* @brief ��λ����ת������
		* @param axis��		���.
		*		 PPR��		ÿת������
		*		 pitch��	�ݾ࣬��λms
		*		 unit_value��	��ת����λ���룬��λms
		*		 pulse_value��	ת���������������λ������
		* @return �ɹ�����0.
		* @remark �����ļ���E450config.ini
		*/
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int Unit_TO_Pulse(int axis, float PPR, float pitch, float unit_value, ref int pulse_value);

		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PTPn_Ex_Register(UInt32 id, UInt32 n_axis,  UInt32[] cardlist,  UInt32[] axislist);
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PTPn_Ex(UInt32 id,  int[] pos, float start_vel, float steady_vel, float end_vel, float acc, float dec, UInt32 sine, int dist_mode);
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PTPn_Ex_GetRunning(UInt32 id, ref UInt32 running);
		[DllImport("sldmv.dll", CharSet =  CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_PTPn_Ex_Stop(UInt32 id, float stop_dec);

		[DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Write_ToUart(UInt32 card_no, UInt32 uart_no, UInt32 num, byte[] data);
		[DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Uart_Trans_Enable(UInt32 card_no, UInt32 uart_no, UInt32 en);
		[DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Read_FromUart(UInt32 card_no, UInt32 uart_no, ref UInt32 num, byte[] data);
		[DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Add_Jump_Up(UInt32 card_no, Jump_Data jump_data);
		[DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Add_Jump_Steady(UInt32 card_no, Jump_Data jump_data);
		[DllImport("sldmv.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
		public static extern int SLDM_Add_Jump_Down(UInt32 card_no, Jump_Data jump_data);
#endif
	}

}


