using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 提示错误信息 message
 */
public class ResErrorMessage : Message 
{
	//系统类型，参见SystemType
	int _systemType;	
	//错误信息编号
	int _errorId;	
	//错误信息参数
	List<string> _errorMsgParam = new List<string>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//系统类型，参见SystemType
		SerializeUtils.WriteInt(stream, _systemType);
		//错误信息编号
		SerializeUtils.WriteInt(stream, _errorId);
		//错误信息参数
		SerializeUtils.WriteShort(stream, (short)_errorMsgParam.Count);

		foreach (var element in _errorMsgParam)  
		{
			SerializeUtils.WriteString(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//系统类型，参见SystemType
		_systemType = SerializeUtils.ReadInt(stream);
		//错误信息编号
		_errorId = SerializeUtils.ReadInt(stream);
		//错误信息参数
		int _errorMsgParam_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _errorMsgParam_length; ++i) 
		{
			_errorMsgParam.Add(SerializeUtils.ReadString(stream));
		}
	}
	
	/**
	 * 系统类型，参见SystemType
	 */
	public int SystemType
	{
		set { _systemType = value; }
	    get { return _systemType; }
	}
	
	/**
	 * 错误信息编号
	 */
	public int ErrorId
	{
		set { _errorId = value; }
	    get { return _errorId; }
	}
	
	/**
	 * get 错误信息参数
	 * @return 
	 */
	public List<string> GetErrorMsgParam()
	{
		return _errorMsgParam;
	}
	
	/**
	 * set 错误信息参数
	 */
	public void SetErrorMsgParam(List<string> errorMsgParam)
	{
		_errorMsgParam = errorMsgParam;
	}
	
	
	public override int GetId() 
	{
		return 201101;
	}
}