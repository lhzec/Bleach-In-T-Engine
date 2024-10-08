using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家向GM发送建议信息回复 message
 */
public class ResPlayerSuggestToGMMessage : Message 
{
	//0:提交成功，1：提交失败
	int _result;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:提交成功，1：提交失败
		SerializeUtils.WriteInt(stream, _result);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:提交成功，1：提交失败
		_result = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0:提交成功，1：提交失败
	 */
	public int Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	
	public override int GetId() 
	{
		return 105111;
	}
}