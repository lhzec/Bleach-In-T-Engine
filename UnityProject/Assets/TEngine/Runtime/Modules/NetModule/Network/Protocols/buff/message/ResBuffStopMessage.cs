using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * Buff停止 message
 */
public class ResBuffStopMessage : Message 
{
	//buff id
	int _buffId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//buff id
		SerializeUtils.WriteInt(stream, _buffId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//buff id
		_buffId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * buff id
	 */
	public int BuffId
	{
		set { _buffId = value; }
	    get { return _buffId; }
	}
	
	
	public override int GetId() 
	{
		return 203102;
	}
}