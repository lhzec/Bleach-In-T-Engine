using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家体力恢复 message
 */
public class ReqPlayerHealthRecoverMessage : Message 
{
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
	}
	
	
	public override int GetId() 
	{
		return 105203;
	}
}