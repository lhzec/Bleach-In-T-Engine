using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 解锁角色回复 message
 */
public class ResUnLockCharacterMessage : Message 
{
	//角色解锁结果(0:成功，1：灵魂不足，
	byte _result;	
	//解锁获得的角色id(解锁失败时为0)
	int _charId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//角色解锁结果(0:成功，1：灵魂不足，
		SerializeUtils.WriteByte(stream, _result);
		//解锁获得的角色id(解锁失败时为0)
		SerializeUtils.WriteInt(stream, _charId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//角色解锁结果(0:成功，1：灵魂不足，
		_result = SerializeUtils.ReadByte(stream);
		//解锁获得的角色id(解锁失败时为0)
		_charId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 角色解锁结果(0:成功，1：灵魂不足，
	 */
	public byte Result
	{
		set { _result = value; }
	    get { return _result; }
	}
	
	/**
	 * 解锁获得的角色id(解锁失败时为0)
	 */
	public int CharId
	{
		set { _charId = value; }
	    get { return _charId; }
	}
	
	
	public override int GetId() 
	{
		return 200201;
	}
}